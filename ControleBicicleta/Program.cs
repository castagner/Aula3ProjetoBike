using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidade;

namespace ControleBicicleta
{
    class Program

   

    {
        static List<Bicicleta> lista = new List<Bicicleta>();

        static void Main(string[] args)
        {




            Bicicleta bike; 
            Fabricante fabricante;
            Cargo cargo; 
            string status;
            status = "N";

            do
            {

                if (status != "L") {

                    bike = new Bicicleta();
                    fabricante = new Fabricante();
                    cargo = new Cargo();


                    Console.WriteLine("Informe o Id");
                    bike.Id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");

                Console.WriteLine("Informe o Modelo");
                    bike.Modelo = (Console.ReadLine());
                Console.WriteLine("\n");

                Console.WriteLine("Informe a Data");
                    bike.DataFabricacao = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("\n");

                Console.WriteLine("Informe o Id do fabricante");
                fabricante.Id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");

                Console.WriteLine("Informe o Nome do fabricante");
                fabricante.Nome = (Console.ReadLine());
                Console.WriteLine("\n");

                Console.WriteLine("Informe o Id do cargo");
                cargo.Id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");

                Console.WriteLine("Informe o Nome do cargo");
                cargo.Descricao = (Console.ReadLine());
                Console.WriteLine("\n");

                    fabricante.Cargo = cargo;
                    bike.Fabricante = fabricante;
                

                lista.Add(bike);

                Console.WriteLine(bike.ToString());

                }
                else
                {

                    Console.WriteLine("Listando: \n");

                    foreach (Bicicleta  b in lista)
                    {

                        Console.WriteLine(b.ToString());
                        Console.WriteLine("\n");

                    }




                }

                Console.WriteLine("\n");
                Console.WriteLine("Deseja criar registro ?");
                Console.WriteLine("S-SIM / N-NÃO / L-Listar");
                status = (Console.ReadLine());


            } while (status == "S" || status == "L");


        }
    }
}
