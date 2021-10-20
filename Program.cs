using System;
using System.Collections.Generic;

namespace DisfrutarProgramando{

    class Program{

        static void Main(string[] args){
            List<string> ciudades = new List<string>(){"Tokyo", "London", "Rome", "Donlon", "Kyoto", "Paris"};

            var res = ciudAnagrama(ciudades);

            ToString(res);

        }
        public static List<List<string>> ciudAnagrama(List<string> lista){

            List<List<string>> LCAnagrama = new List<List<string>>();

            List<string> LAux = new List<string>();

            for (var i = 0; i < lista.Count; i++){

                LAux.Add(lista[i]);

                for(var j = i + 1; j < lista.Count; j++){
                    
                    if(cambiarSilabas(lista[i].ToLower()) == cambiarSilabas(lista[j]).ToLower()){

                        LAux.Add(lista[j]);
                        lista.RemoveAt(j);
                    }

                }

                LCAnagrama.Add(LAux);
                LAux = new List<string>();
            }

            return LCAnagrama;
        }

        public static string cambiarSilabas(string ciudad){

            char[] SAnagrama = ciudad.ToCharArray();  

            for(var i=1;i< SAnagrama.Length;i++){  

                for(var j=0;j< SAnagrama.Length-1;j++){  

                    if(SAnagrama[j]> SAnagrama[j+1]){  

                        var aux = SAnagrama[j];  
                        SAnagrama[j] = SAnagrama[j + 1];  
                        SAnagrama[j + 1] = aux;  
                }  
           }  
       }  

            var res = new string(SAnagrama);

            return res;
        }
        public static void ToString(List<List<string>> lista){

                var sRes = "[\n";
                
                for(var i = 0; i < lista.Count; i++){
                    sRes += "\t[ " + (string.Join( ", ", lista[i].ToArray()).ToString() + " ],\n");
                }

                sRes += "]\n";

                Console.Write(sRes);
        }
    }
}