using System;

namespace ArrayColection
{
    class Program
    {
        static void Main(string[] args)
        {
            // string [] alunosAMS = nova string [5] {
              // "Pedro",
              // "Bruno",
              // "Duda",
              // "Vitor",
              // "Lucas"
          // };

          // Console.WriteLine (alunosAMS [2]);

          // alunosAMS [2] = "Julia";

         // Console.WriteLine ($"o novo valor do índice 2 {alunosAMS [2]}");

           // foreach (string Aluno em alunosAMS)
           // {
           //     Console.WriteLine (Aluno);
          // }

          string [] alunosAMS  =  nova  string [ 5 ];
          alunosAMS [ 0 ] =  " Pedro ";
          alunosAMS [ 1 ] =  " Bruno ";
          alunosAMS [ 2 ] =  " Julia ";
          alunosAMS [ 3 ] =  " Vitu ";
          alunosAMS [ 4 ] =  " Lucas ";

          Console . WriteLine ( alunosAMS [ 2 ]);

          alunosAMS [ 2 ] =  " Duda " ;

          Console . WriteLine ($" O novo valor atribuído a essa variável é: { alunosAMS [ 2 ]} ");

          for ( int  i  =  0 ; i  <  alunosAMS . Comprimento ; i ++ )
          {
               Console . WriteLine ($" Os nomes são: { alunosAMS [ i ]} ");
          }

        }
    }
}
