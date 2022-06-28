using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urna
{

    /*
    10	Cão Caramelo
    20	Cão Dogecoin
    30	Cão Neguinha
    40	Cão Pinscher Branco
    50	Cão Pinscher Neguinha     
    */

    public static class candidatos
    {
        public static string
            caramelo = "Caramelo",
            dogecoin = "Dogecoin",
            neguinha = "Neguinha",
            pinscherBranco = "Pinscher Branco",
            pinscherNeguinha = "Pinscher Neguinha",
            Branco = "Branco",
            vote = "Vote";

        public static string imagens = "C:/Users/matheus.bpaulino/Desktop/Candidatos/";

        public static int totalVotos = 0;
        public static int vCaramelo = 0, vDogecoin = 0, vNeguinha = 0, vPinscherBranco = 0, vPinscherNeguinha = 0, vBranco = 0, vNulo = 0;
    }

}
