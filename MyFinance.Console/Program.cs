﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFinance.Service;
using MyFinance.Domain.Entities;
using MyFinance.Data;
using MyFinance.Domain.Entities.Entitiess;

namespace MyFinance.Console
{
    public class Program
    {
        static void Main(string[] args)
        {

            /********************* 
             * using context 
             * *****************/
            // GOContext context = new GOContext();
            // context.Patients.Add(new Patient { Cin = 1233, Description = "test", Email = "amal.test@gmail.com", Adress = "ddada", NomComplet = new FullName { firstName = "Amal", lastName = "Hichri" } });
            // context.SaveChanges();




            /********************* 
             * using services 
             * *****************/


            //IPatientService productService = new PatientService();
            //productService.Add(new Patient { Cin = 1233, Description = "test", Email = "amal.test@gmail.com", Adress = "ddada", NomComplet = new FullName { firstName = "Amal", lastName = "Hichri" } });


            // adding using the interface
            /*IOperationService operationService = new OperationService();
            operationService.Add(new Operation {DateDebut = new DateTime(2010, 8, 18), DateFin=new DateTime(2010,8,18),Duree=4,Etat=true});
            operationService.Commit();*/

            /************************ OPERAIONS ******************/
            /* adding using the class 
            OperationService optService = new OperationService();
            optService.Add(new Operation { DateDebut = new DateTime(2014, 8, 19), DateFin = new DateTime(2010, 8, 18), Duree = 47, Etat = true });
            optService.Add(new Operation { DateDebut = new DateTime(2014, 8, 22), DateFin = new DateTime(2010, 8, 18), Duree = 3, Etat = true });
            optService.Commit();

            // display list of operations with " Etat = true "
            ((optService.GetOperationsReussies()).ToList()).ForEach(o => System.Console.WriteLine("Id: " + o.OperationId + "/ Date debut: " + o.DateDebut + " / Date fin: " + o.DateFin + "/ Duree:" + o.Duree + "/ Etat" + o.Etat));
            
            // get the average of all operations durations
             int avg = 0, sum = 0;
            ((optService.GetAllOperations()).ToList())
                .ForEach(o => {
                    sum = sum + o.Duree;
                   
                });
            System.Console.WriteLine("Duration sum: " + sum);
            avg = sum / (optService.GetAllOperations()).ToList().Count;
            System.Console.WriteLine("Operations nb: " + (optService.GetAllOperations()).ToList().Count);
            System.Console.WriteLine("Average: " + avg);
            optService.Commit();
            System.Console.ReadLine();*/


            /************************ CHIRURGIEN ******************/
            ChirurgienService chirurgienService = new ChirurgienService();
            ICollection<Operation> ops = new List<Operation>();
            ICollection<Operation> ops2 = new List<Operation>();
            ops.Add(new Operation { DateDebut = new DateTime(2014, 8, 19), DateFin = new DateTime(2010, 8, 18), Duree = 47, Etat = true });
            ops.Add(new Operation { DateDebut = new DateTime(2014, 8, 19), DateFin = new DateTime(2010, 8, 18), Duree = 47, Etat = true });
            ops.Add(new Operation { DateDebut = new DateTime(2014, 8, 19), DateFin = new DateTime(2010, 8, 18), Duree = 47, Etat = false });
            ops2.Add(new Operation { DateDebut = new DateTime(2014, 8, 19), DateFin = new DateTime(2010, 8, 18), Duree = 47, Etat = true });
            ops2.Add(new Operation { DateDebut = new DateTime(2014, 8, 19), DateFin = new DateTime(2010, 8, 18), Duree = 47, Etat = true });
            ops2.Add(new Operation { DateDebut = new DateTime(2014, 8, 19), DateFin = new DateTime(2010, 8, 18), Duree = 47, Etat = true });
            chirurgienService.Add(new Chirurgien
            {
                Age = 40,
                NomComplet = { firstName = "Amal", lastName = "Hichri" },
                Nbre_annee_exp = 15,
                Note_xp = 20,
                Operations = ops
            });
            chirurgienService.Add(new Chirurgien
            {
                Age = 54,
                NomComplet = { firstName = "AAAl", lastName = "Hhhhh" },
                Nbre_annee_exp = 25,
                Note_xp = 30,
                Operations = ops2
            });

            (chirurgienService.GetChirurgiensNonReussis()).ToList().ForEach(
                c =>
                {
                    System.Console.WriteLine("Nom: " + c.NomComplet+" / OperationId: "+(c.Operations.ToList().Find(o=>o.Etat==false)).OperationId);
                });
            chirurgienService.Commit();
            System.Console.ReadLine();
        }
    }
}
