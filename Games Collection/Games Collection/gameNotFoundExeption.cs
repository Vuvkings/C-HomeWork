using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games_Collection
{
    public class GameNotFoundExeption : Exception
    {
        public GameNotFoundExeption(string value) : base($"Не удалось обнаружить игру по {value}") { }
        public GameNotFoundExeption() : base("Игра не обнаружена") { }
    }
}
