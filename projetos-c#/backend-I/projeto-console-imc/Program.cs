//Crie um progama para calcular o IMC de uma pessoa

//ALgoritmo
//entrada: nome, idade, peso, idade
//processamento: peso dividido por altura ao quadrado

//entrada

// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         Console.BackgroundColor = ConsoleColor.White;
//         Console.WriteLine(@$"
// --------------------
// |  PROGRAMA PARA   |
// |  CALCULAR O IMC  |
// --------------------
// ");
//         Console.ResetColor();

//         Console.WriteLine("Digite o nome do paciente:");
//         string nome = Console.ReadLine();

//         Console.WriteLine($"Bem vindo ao nosso sistema {nome} ;) S2 ");

//         Console.WriteLine($"Para continuar informe o peso do paciente:");
//         float peso = float.Parse(Console.ReadLine());

//         Console.WriteLine($"E agora informe a altura do paciente:");
//         float altura = float.Parse(Console.ReadLine());

//         double imc = peso / (altura * altura);

//         Console.WriteLine($"O IMC do(a) {nome} e de: {imc}" + Math.Round(imc, 2));

//         Console.WriteLine($"Obrigado por utilizar nosso sistema {nome} ate a proxima :)");

//         Console.WriteLine(@$"
//              ..----..                                                                    
//                                                               ------..        ..                                                            
//                                               --            ::::----..          ..                                                          
//                                             ::##..        ..MMMMMM            ..::::        --++::                                          
//                                             ::##++..      @@mm++mm@@::    ..::@@MMmm++      MM++::                                          
//                                             --mmMM@@::  ::MMmm++++mm@@--..--MM++++::::..--++mm::                                            
//                                                     mmMMMM@@MMmmmmMM##mm::++mmmm++++++--::                                                  
//                                                       mmMM##@@MM++++##MM::::mm@@##..++::..                                                  
//                                                       mmMM@@MM@@@@--##--  --MMMM##..--..                                                    
//                                                     --mm::--++mm++::::..    ..++mm::..                                                      
//                                                     --mm--..  ::mm++::--........                                                            
//                                                     ::++------@@@@@@MM::--------++                                                          
//                                                     ++mmmmmmMM@@######@@MMMMMM@@::++..                                                      
//                                                     ++mmmmMMmm++++::::::::::--..  ..MM--                                                    
//                                                     ++++++mm@@mm++::......--      ....::..                                                  
//                                                     ++++mmmmmm++@@++--....      ..::++                                                      
//                                                     ++mmmmmmmmmmmm--::MMMM@@mm::  ..                                                        
//                                                   ++MMmmmmmmmmMMmmmm++++++::------..                                                        
//                                                 --mmMMmmmmmmmmMMmmmm++++::::--------..  ..                                                  
//                                                 ++mmmmMMmmmmmmMMMMmm++++++::::------..  ..                                                  
//                                               MM@@MMmmMMmmmmmmmmmmmm::::::------..      ..              ..                                  
//                                             @@####MMmmMMMMMMmmmmmm::--------..      ......                                                  
//                                           ##########MMMMMMMMMMmmmm++::--..--..........  ..                    ......                        
//                                       --######@@@@@@##@@MMMMMM@@MMMM++::::::------::--..  ..                  ......--                      
//                                 ----++mm@@######MMMMMM@@@@MMMMMM@@@@@@MMMMMMMM++::----                          ....----                    
//                             ::::::::::++MM####mmmm++++::MM@@@@MM@@@@MMmm::::::::----..                        ....--------                  
//                         ::::::::--------++@@mm++::::::----::::--::::::----::------..                        ......------::                  
//                       ++++++::--------::++::::::--------....      ..------------..                        ........----::::--                
//                     mmmm++++::::------::::--................        --------..                      ........------------::::..              
//                   mmmmmm++++::::----::::----........  ......        ::::--....                    ..--..--------------::::::::              
//                 ::mmmmmm++++::::::::::::----................        ------....                  ....--::::--------::::::::::::              
//                 mmmmmmmm++++++::++++::::----......      ..        ..++::--....                ....--::++++::::::::::::::++++++              
//               ::mmmmmmmm++++++++++++++::::------....                ++::::--....            ......--::mmmm++::::::::::::++++mm..            
//               mmMMMMmmmmmm++++++mmmmmm++::----........          ....mm++::::....          ..------::++mm##MMmm++mm++++++++mmmmmm            
//               MMMM@@MMmmmmmmmmmmMMmmmm++::::----......          ....++++::----............--::::::++++MM####MMMMmmmm++++mmmm++::            
//             mmMM@@MMMMMMMMMMMM@@@@MM++++::::::----......        ----mm++++::------------::::::++++mmmmMM####@@MMMMmm++mmmm++::--::          
//             MM@@MM@@@@@@MM@@######MMmmmm++++::::::----....  ....--::##@@mm++++::::::::::::++++++mmmmMMMM@@--------::mm++++::----::          
//             MM@@MMMM@@@@##########@@MMMMmmmm++::::::::------..::::::####@@mmmm++::++++++++mmmmmmMMMM@@@@++..  ....--::++++------::++        
//             ::@@@@MM@@################@@MMmmmm++++++::::::::++++mmmm@@####MMmmmm++mm++mmmmmmMM@@####@@##::....  ....::::--------::++        
//             MM@@MMMMMM@@##################@@MMmmmmmm++++::++++mmmm::mm####@@MMMMMMmmMMMMMMMM@@##########::----------::--------::::++      mm
//           ::mmmmMMmmmm++++MM########@@######@@MMMMMMmmmmmmmmmmmm++::mm########@@@@@@@@##################::::------::--....--::::::++      mm
//           mm++++mmmm++----::mm####################@@@@@@@@@@MMMMmm--mm############@@@@##################mm++::::::::--....--::::++++    mmmm
//         ..mm++++mmmm++....::mm##################@@############..    ....################################mm++::::::::--------++++++mm        
//         mmmm++++mmmm::::::::++############################MM::--  ....--..::++##########################MM++::::::::----::--::++mmMM      --
//         mmmmmm++mmmm::::::++mm##########################MMmmmm::--::::------::++mmMM####################MMmm++++::--::----::::mm++MM        
//         MMmmmm++mmMM++::::++mm##########################@@MMMMmm::::++++--::++++++mmMM##########@@@@####@@mm++++::::::::--::++++++mm        
//         MMMMmmmmmm++++::::++mm##################@@mmMMMM++::--..--::::--  ....--::mmMMMMMM@@MM@@MMMM######mmmmmm::::::--::::++++mm          
//         MMMMmmmmmm::++++++mmMM##################MMmm++++::::--....--++::--  ..--::++mmmmmmMMMMMMMMMM@@####MMmmmm++::::::::::::++mm--        
//         MMmmmmmmmm++++++++mm@@##  ############MM@@##mm++++++::..--::++::--..--::::::++++++++mmMMMMMM@@@@####MMmmMM++++++::--::++mm::        
//       mmMMMM++mm++++++++++mm@@@@    ##########@@mmmmMMMMmmmm++------++mm::--::++++++++::::::mmMM@@MMMMMM  ##@@MM@@MMMM++::--::::++..        
//       mmmmmmmmmm++++++++mmMM##      ##############MM@@@@@@@@MMmm::--::MMmmmmmmmmMM++++::::++mmMM@@MMmm++  ##########MM++::----::++          
//       mmmmmmmmmmmmmmmm++mmMM##        ##@@MMMMMM############@@@@mm::::MM@@++MM@@@@MMmm++++mmMMMMMMMMmm      ########MM::::----::++..        
//       mm++++mmMMMMmmmmmmMM##MM        ##@@mm++++::##MM++::::--....++----....----++mmMMMMMMmmmmmmMMMM        MM######++--------++++mm        
//       mm++--++@@MM@@MMMM@@##          ##MMmm++----MMmm++++::--..::--++::....--::::++mm++::++++++mmMM          ######++::--....++++MM        
//       ++::----@@##########mm          ##MMmm++::::mmmmmmmm++::--::--++::----::++++++++::--::++::++--          ++##++::----..--::++MM        
//       ++::--..++########@@            ##MMmm++::--MM@@mmmmmm::::::::++++..--::++++++++----::++++::            ..++++::----..::++MM::        
//       ++::..--::MM####@@              @@MMmm++--::MM##MMMMmm++::::::mm++::::++mm++mm++----::++++++            ##++::::::----++++MM##        
//       ++::....--mm####@@              MMMMmmmm++::mm######MMmmmm++++MMmmmm++++mmmmmm++----::++++mm            mm++++::::::::++mm####        
//       ++::....--::++MMmm            ..MMMMmmmm::++mmmmMMmmmmmm++++++mmmmMMmmMMMMmmMM++--::::++mmmm            ++++::::::::mmmmMM@@@@        
//       mm::--..--::::::mm            MMmmmmmmmm++++mmMM++++++::::mm++::--::++mmmmMMmm::--::++++MM..            ::++::::::++++++mmMMMM        
// ");
//     }
// }


// // Console.WriteLine($"O IMC do(a) " + nome + " e de: "  + Math.Round(imc, 2));

// //anotações

// //float.parse ou double.parse serve para converter uma função que só serviria em string em float



