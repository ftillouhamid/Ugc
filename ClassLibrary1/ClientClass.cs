using System;
using System.Collections.Generic;
using System.Text;

namespace UgcClassLibrary
{
    public class ClientClass
    {
        public int id { get; set; }                         //0
        public string code { get; set; }                    //1
        public string raison { get; set; }                  //7
        public string fixe { get; set; }                    //10
        public string mobile { get; set; }                  //11
        public string fax { get; set; }                     //12
        public string email { get; set; }                   //13
        public string adresse { get; set; }                 //8
        public string code_postal { get; set; }             //9
        public decimal solde { get; set; }                  //15
        public decimal chiffre_affaire { get; set; }        //16
        public int type_id { get; set; }                    //2
        public int titre_id { get; set; }                   //3
        public int ville_id { get; set; }                   //4
        public int famille_id { get; set; }                 //5
        public int modereglement_id { get; set; }           //6
        public string observations { get; set; }            //17
        public string logo { get; set; }                    //18

        public ClientClass()
        {

        }

    }
}
