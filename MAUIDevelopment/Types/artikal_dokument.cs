﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace MAUIDevelopment.Model.Types
{
    public partial class artikal_dokument
    {
        public artikal_dokument()
        {
            artikal_dnevnik = new HashSet<artikal_dnevnik>();
        }

        public int id_dokument { get; set; }
        public byte id_vrsta { get; set; }
        public short? broj { get; set; }
        public string broj_dok { get; set; }
        public DateTime? datum_fak { get; set; }
        public DateTime? datum_val { get; set; }
        public DateTime datum { get; set; }
        public int? id_partner { get; set; }
        public string valuta { get; set; }
        public byte? id_placanje { get; set; }
        public short id_mjesto { get; set; }
        public decimal ztn_car { get; set; }
        public decimal ztn_tra { get; set; }
        public decimal ztn_man { get; set; }
        public decimal ztn_ost { get; set; }
        public short? id_mjesto2 { get; set; }
        public string op_create { get; set; }
        public int? id_finansije { get; set; }
        public int? id_vozilo { get; set; }
        public string napomena { get; set; }
        public int? id_sredstvo { get; set; }
        public int? id_ambalaza { get; set; }
        public int? id_objekat { get; set; }
        public int? id_kvar { get; set; }
        public DateTime? created { get; set; }
        public DateTime? updated { get; set; }
        public string op_update { get; set; }
        public DateTime? finalized { get; set; }
        public string op_finalize { get; set; }
        public string mjesto_created { get; set; }
        public short? id_isporuka { get; set; }
        public int? id_fiscal { get; set; }
        public bool editing { get; set; }
        public short? id_ugovor { get; set; }
        public int? id_nosilac { get; set; }

        public virtual fiscal_dokument id_fiscalNavigation { get; set; }
        public virtual partner id_partnerNavigation { get; set; }
        public virtual dokument_vrsta id_vrstaNavigation { get; set; }
        public virtual ICollection<artikal_dnevnik> artikal_dnevnik { get; set; }
    }
}