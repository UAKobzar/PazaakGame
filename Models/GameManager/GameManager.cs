using Models.Decks;
using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.GameManager
{
    public class GameManager
    {
        private Player.Player[] _players;

        private int _playerTurn;

        private BasicDeck _deck;

        public GameManager()
        {
            _deck = new BasicDeck();
            _players = new Player.Player[2];
            for (int i = 0; i < 2; i++)
            {
                _players[i] = new Player.Player();
            }
            _playerTurn = 0;
        }

        public void Reset()
        {
            _deck.Shuffle();
            for (int i = 0; i < 2; i++)
            {
                _players[i].Board.Reset();
            }
        }

        public GameResult Turn(Turn turn, int? sideCardIndex = null)
        {
            var result = ProcessTurn(turn, sideCardIndex);

            switch (result)
            {
                case GameResult.Running:
                    break;
                case GameResult.Player1Win:
                    _players[0].Wins++;
                    Reset();
                    break;
                case GameResult.Player2Win:
                    _players[1].Wins++;
                    Reset();
                    break;
                case GameResult.Tie:
                    Reset();
                    break;
                default:
                    break;
            }

            return result;
        }

        private GameResult ProcessTurn(Turn turn, int? sideCardIndex = null)
        {
            if(turn == Enums.Turn.SideCard)
            {
                _players[_playerTurn].PlaySideCard(sideCardIndex.Value);
            }
            else
            {
                if(turn == Enums.Turn.Stand || _players[_playerTurn].Board.GetValue() == 20)
                {
                    _players[_playerTurn].StandMove();
                }

                if(_players[_playerTurn].Board.GetValue() > 20)
                {
                    _players[0].StandMove();
                    _players[1].StandMove();
                }

                if(!_players[1 - _playerTurn].Stand)
                {
                    _playerTurn = 1 - _playerTurn;
                }

                if(IsEnd())
                {
                    return GetResult();
                }

                var card = _deck.GetNextCard();
                _players[_playerTurn].Board.AddToBoard(card);
            }

            return GameResult.Running;
        }

        public bool IsEnd()
        {
            return _players.All(p => p.Stand == true);
        }

        public GameResult GetResult()
        {
            int player1Value = _players[0].Board.GetValue();
            int player2Value = _players[1].Board.GetValue();

            if (player1Value > 20)
                return GameResult.Player2Win;
            if (player2Value > 20)
                return GameResult.Player1Win;
            if (player1Value > player2Value)
                return GameResult.Player1Win;
            if (player2Value > player1Value)
                return GameResult.Player2Win;
            if (_players[0].Board.HasTieBreaker())
                return GameResult.Player1Win;
            if (_players[1].Board.HasTieBreaker())
                return GameResult.Player2Win;
            return GameResult.Tie;
        }
    }
}
