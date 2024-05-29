using System;
using System.Collections.Generic;
using System.Linq;

namespace Puntajes_Mas_Altos
{
    /*
       Consigna: 
           Administre la lista de puntuaciones más altas de un jugador.

           Tu tarea es crear un componente de puntuación alta del clásico juego Frogger,
    uno de los juegos más vendidos y adictivos de todos los tiempos, y un clásico de la era arcade.

           Su tarea es escribir métodos que devuelvan la puntuación más alta de la lista,
    la última puntuación agregada y las tres puntuaciones más altas.
   */

    public class HighScores
    {
        private List<int> scores = new List<int>(); 

        public HighScores(List<int> list)
        {
            scores = list;
        }

        public List<int> Scores()
        {
            return scores;
        }

        public int Latest()
        {
            return scores.Last();
        }

        public int PersonalBest()
        {
            return scores.Max(x => x);
        }

        public List<int> PersonalTopThree()
        {
            return scores.OrderByDescending(n => n).Take(3).ToList();
        }
    }
}
