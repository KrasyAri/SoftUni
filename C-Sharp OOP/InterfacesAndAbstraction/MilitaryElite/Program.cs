using MilitaryElite.Interfaces;
using MilitaryElite.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MilitaryElite
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<ISoldier> allSoldiers = new List<ISoldier>();
            HashSet<Private> privates = new HashSet<Private>();

            //string[] input = Console.ReadLine().Split();

            //while (input[0] != "End")
            //{
            //    switch (input[0])
            //    {
            //        case "Private":
            //            Private priv = new Private(int.Parse(input[1]), input[2], input[3], decimal.Parse(input[4]));
            //            allSoldiers.Add(priv);
            //            privates.Add(priv);
            //            break;

            //        case "LeutenantGeneral":
            //            LieutenantGeneral lieutenantGeneral = new LieutenantGeneral
            //                (int.Parse(input[1]), input[2], input[3], decimal.Parse(input[4]));

            //            input = input.Skip(5).ToArray();

            //            for (int i = 0; i < input.Length; i++)
            //            {
            //                Private privateToAdd = privates.First(p => p.Id == int.Parse(input[i]));
            //                lieutenantGeneral.Privates.Add(privateToAdd);
            //            }

            //            allSoldiers.Add(lieutenantGeneral);
            //            break;

            //        case "Engineer":
            //            Engineer engineer = new Engineer(int.Parse(input[1]), input[2], input[3], decimal.Parse(input[4]), input[5]);

            //            if (engineer.Corps == "Airforces" || engineer.Corps == "Marines")
            //            {
            //                input = input.Skip(6).ToArray();

            //                for (int i = 0; i < input.Length; i += 2)
            //                {
            //                    Repair repair = new Repair(input[i], int.Parse(input[i + 1]));
            //                    engineer.Repairs.Add(repair);
            //                }

            //                allSoldiers.Add(engineer);
            //            }

            //            break;

            //        case "Commando":
            //            Commando commando = new Commando(int.Parse(input[1]), input[2], input[3], decimal.Parse(input[4]), input[5]);

            //            if (commando.Corps == "Airforces" || commando.Corps == "Marines")
            //            {
            //                input = input.Skip(6).ToArray();

            //                for (int i = 0; i < input.Length; i++)
            //                {
            //                    Mission mission = new Mission(input[i], input[i + 1]);

            //                    if (mission.State == "inProgress" || mission.State == "Finished")
            //                    {
            //                        commando.Missions.Add(mission);
            //                    }
            //                }

            //                allSoldiers.Add(commando);
            //            }
            //            break;

            //        case "Spy":

            //            Spy spy = new Spy(int.Parse(input[1]), input[2], input[3], int.Parse(input[4]));
            //            allSoldiers.Add(spy);

            //            break;
            //    }


            //    input = Console.ReadLine().Split();

            //}

            //foreach (var soldier in allSoldiers)
            //{
            //    Console.WriteLine(soldier.ToString());
            //}

            while (true)
            {
                string[] data = Console.ReadLine().Split();

                string soldierType = data[0];

                data = data.Skip(1).ToArray();

                if (soldierType == "End")
                {
                    break;
                }

                switch (soldierType)
                {
                    case "Private":

                        Private priv = new Private(int.Parse(data[0]), data[1], data[2], decimal.Parse(data[3]));

                        allSoldiers.Add(priv);
                        privates.Add(priv);

                        break;

                    case "LieutenantGeneral":

                        LieutenantGeneral lieutenant = new LieutenantGeneral(int.Parse(data[0]), data[1], data[2], decimal.Parse(data[3]));

                        data = data.Skip(4).ToArray();

                        for (int i = 0; i < data.Length; i++)
                        {
                            Private privToAdd = privates.First(p => p.Id == int.Parse(data[i]));

                            lieutenant.Privates.Add(privToAdd);
                        }

                        allSoldiers.Add(lieutenant);

                        break;

                    case "Engineer":

                        Engineer engineer = new Engineer(int.Parse(data[0]), data[1], data[2], decimal.Parse(data[3]), data[4]);

                        if (engineer.Corps == "Airforces" || engineer.Corps == "Marines")
                        {
                            data = data.Skip(5).ToArray();

                            for (int i = 0; i < data.Length; i += 2)
                            {
                                Repair repair = new Repair(data[i], int.Parse(data[i + 1]));
                                engineer.Repairs.Add(repair);
                            }

                            allSoldiers.Add(engineer);
                        }

                        break;

                    case "Commando":

                        Commando commando = new Commando(int.Parse(data[0]), data[1], data[2], decimal.Parse(data[3]), data[4]);

                        if (commando.Corps == "Airforces" || commando.Corps == "Marines")
                        {
                            data = data.Skip(5).ToArray();

                            for (int i = 0; i < data.Length; i += 2)
                            {
                                Mission mission = new Mission(data[i], data[i + 1]);

                                if (mission.State == "Finished" || mission.State == "inProgress")
                                {
                                    commando.Missions.Add(mission);
                                }
                            }

                            allSoldiers.Add(commando);
                        }

                        break;

                    case "Spy":

                        Spy spy = new Spy(int.Parse(data[0]), data[1], data[2], int.Parse(data[3]));

                        allSoldiers.Add(spy);

                        break;
                }

                GC.Collect();
            }

            foreach (var soldier in allSoldiers)
            {
                Console.WriteLine(soldier.ToString());
            }
        }

    }
}
