using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WyszukiwarkaLotówDR.Data;
using WyszukiwarkaLotówDR.Loty;
using WyszukiwarkaLotówDR.Models;

namespace WyszukiwarkaLotówDR.Baza_danych
{
    public class BazaLotów:IBazaLotów
    {
        List<LotModel> listaLotow = new List<LotModel>()
        {
            
        };

        
        public void addLot(LotModel lot)
        {
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=DbForEFdemo; Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from [dbo].[LotyModel]", con);
            SqlDataReader ore = cmd.ExecuteReader();
            while (ore.Read())
            {
                if (Convert.ToString(ore["Przewoznik"]) == "2")
                    this.listaLotow.Add(new LotModel(Convert.ToInt32(ore["Id"]), Models.Przewoznik.LOT, Convert.ToDateTime(ore["czasWylotu"]), Convert.ToDateTime(ore["czasPrzylotu"]), Convert.ToString(ore["miejsceWylotu"]), Convert.ToString(ore["miejscePrzylotu"]), Convert.ToString(ore["kodLotniskaWylotu"]), Convert.ToString(ore["kodLotniskaPrzylotu"]), Convert.ToDouble(ore["cenaBiletu"]), Convert.ToInt32(ore["iloscMiejsc"]), Convert.ToString(ore["Obraz"])));
                if (Convert.ToString(ore["Przewoznik"]) == "1")
                    this.listaLotow.Add(new LotModel(Convert.ToInt32(ore["Id"]), Models.Przewoznik.EnterAir, Convert.ToDateTime(ore["czasWylotu"]), Convert.ToDateTime(ore["czasPrzylotu"]), Convert.ToString(ore["miejsceWylotu"]), Convert.ToString(ore["miejscePrzylotu"]), Convert.ToString(ore["kodLotniskaWylotu"]), Convert.ToString(ore["kodLotniskaPrzylotu"]), Convert.ToDouble(ore["cenaBiletu"]), Convert.ToInt32(ore["iloscMiejsc"]), Convert.ToString(ore["Obraz"])));
                if (Convert.ToString(ore["Przewoznik"]) == "3")
                    this.listaLotow.Add(new LotModel(Convert.ToInt32(ore["Id"]), Models.Przewoznik.Lufthansa, Convert.ToDateTime(ore["czasWylotu"]), Convert.ToDateTime(ore["czasPrzylotu"]), Convert.ToString(ore["miejsceWylotu"]), Convert.ToString(ore["miejscePrzylotu"]), Convert.ToString(ore["kodLotniskaWylotu"]), Convert.ToString(ore["kodLotniskaPrzylotu"]), Convert.ToDouble(ore["cenaBiletu"]), Convert.ToInt32(ore["iloscMiejsc"]), Convert.ToString(ore["Obraz"])));
                if (Convert.ToString(ore["Przewoznik"]) == "0")
                    this.listaLotow.Add(new LotModel(Convert.ToInt32(ore["Id"]), Models.Przewoznik.Ryanair, Convert.ToDateTime(ore["czasWylotu"]), Convert.ToDateTime(ore["czasPrzylotu"]), Convert.ToString(ore["miejsceWylotu"]), Convert.ToString(ore["miejscePrzylotu"]), Convert.ToString(ore["kodLotniskaWylotu"]), Convert.ToString(ore["kodLotniskaPrzylotu"]), Convert.ToDouble(ore["cenaBiletu"]), Convert.ToInt32(ore["iloscMiejsc"]), Convert.ToString(ore["Obraz"])));
                if (Convert.ToString(ore["Przewoznik"]) == "4")
                    this.listaLotow.Add(new LotModel(Convert.ToInt32(ore["Id"]), Models.Przewoznik.TurkishAirlines, Convert.ToDateTime(ore["czasWylotu"]), Convert.ToDateTime(ore["czasPrzylotu"]), Convert.ToString(ore["miejsceWylotu"]), Convert.ToString(ore["miejscePrzylotu"]), Convert.ToString(ore["kodLotniskaWylotu"]), Convert.ToString(ore["kodLotniskaPrzylotu"]), Convert.ToDouble(ore["cenaBiletu"]), Convert.ToInt32(ore["iloscMiejsc"]), Convert.ToString(ore["Obraz"])));

            }
            con.Close();
            int idx = listaLotow.Max(l => l.Id) + 1;
            lot.Id = idx;
            listaLotow.Add(lot);
        }

        public void deleteLot(int id)
        {

            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=DbForEFdemo; Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from [dbo].[LotyModel]", con);
            SqlDataReader ore = cmd.ExecuteReader();
            while (ore.Read())
            {
                if (Convert.ToString(ore["Przewoznik"]) == "2")
                    this.listaLotow.Add(new LotModel(Convert.ToInt32(ore["Id"]), Models.Przewoznik.LOT, Convert.ToDateTime(ore["czasWylotu"]), Convert.ToDateTime(ore["czasPrzylotu"]), Convert.ToString(ore["miejsceWylotu"]), Convert.ToString(ore["miejscePrzylotu"]), Convert.ToString(ore["kodLotniskaWylotu"]), Convert.ToString(ore["kodLotniskaPrzylotu"]), Convert.ToDouble(ore["cenaBiletu"]), Convert.ToInt32(ore["iloscMiejsc"]), Convert.ToString(ore["Obraz"])));
                if (Convert.ToString(ore["Przewoznik"]) == "1")
                    this.listaLotow.Add(new LotModel(Convert.ToInt32(ore["Id"]), Models.Przewoznik.EnterAir, Convert.ToDateTime(ore["czasWylotu"]), Convert.ToDateTime(ore["czasPrzylotu"]), Convert.ToString(ore["miejsceWylotu"]), Convert.ToString(ore["miejscePrzylotu"]), Convert.ToString(ore["kodLotniskaWylotu"]), Convert.ToString(ore["kodLotniskaPrzylotu"]), Convert.ToDouble(ore["cenaBiletu"]), Convert.ToInt32(ore["iloscMiejsc"]), Convert.ToString(ore["Obraz"])));
                if (Convert.ToString(ore["Przewoznik"]) == "3")
                    this.listaLotow.Add(new LotModel(Convert.ToInt32(ore["Id"]), Models.Przewoznik.Lufthansa, Convert.ToDateTime(ore["czasWylotu"]), Convert.ToDateTime(ore["czasPrzylotu"]), Convert.ToString(ore["miejsceWylotu"]), Convert.ToString(ore["miejscePrzylotu"]), Convert.ToString(ore["kodLotniskaWylotu"]), Convert.ToString(ore["kodLotniskaPrzylotu"]), Convert.ToDouble(ore["cenaBiletu"]), Convert.ToInt32(ore["iloscMiejsc"]), Convert.ToString(ore["Obraz"])));
                if (Convert.ToString(ore["Przewoznik"]) == "0")
                    this.listaLotow.Add(new LotModel(Convert.ToInt32(ore["Id"]), Models.Przewoznik.Ryanair, Convert.ToDateTime(ore["czasWylotu"]), Convert.ToDateTime(ore["czasPrzylotu"]), Convert.ToString(ore["miejsceWylotu"]), Convert.ToString(ore["miejscePrzylotu"]), Convert.ToString(ore["kodLotniskaWylotu"]), Convert.ToString(ore["kodLotniskaPrzylotu"]), Convert.ToDouble(ore["cenaBiletu"]), Convert.ToInt32(ore["iloscMiejsc"]), Convert.ToString(ore["Obraz"])));
                if (Convert.ToString(ore["Przewoznik"]) == "4")
                    this.listaLotow.Add(new LotModel(Convert.ToInt32(ore["Id"]), Models.Przewoznik.TurkishAirlines, Convert.ToDateTime(ore["czasWylotu"]), Convert.ToDateTime(ore["czasPrzylotu"]), Convert.ToString(ore["miejsceWylotu"]), Convert.ToString(ore["miejscePrzylotu"]), Convert.ToString(ore["kodLotniskaWylotu"]), Convert.ToString(ore["kodLotniskaPrzylotu"]), Convert.ToDouble(ore["cenaBiletu"]), Convert.ToInt32(ore["iloscMiejsc"]), Convert.ToString(ore["Obraz"])));

            }
            con.Close();
            Console.WriteLine(id);
            int idx = 0;
            bool ok = false;
            for(int i = 0; i < listaLotow.Count; i++)
            {
                if (listaLotow[i].Id == id)
                {
                    ok = true;
                    idx = i;
                }
            }
            Console.WriteLine(idx);
            if (ok) listaLotow.RemoveAt(idx);

        }

        public LotModel getLot(int id)
        {
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=DbForEFdemo; Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from [dbo].[LotyModel]", con);
            SqlDataReader ore = cmd.ExecuteReader();
            while (ore.Read())
            {
                if (Convert.ToString(ore["Przewoznik"]) == "2")
                    this.listaLotow.Add(new LotModel(Convert.ToInt32(ore["Id"]), Models.Przewoznik.LOT, Convert.ToDateTime(ore["czasWylotu"]), Convert.ToDateTime(ore["czasPrzylotu"]), Convert.ToString(ore["miejsceWylotu"]), Convert.ToString(ore["miejscePrzylotu"]), Convert.ToString(ore["kodLotniskaWylotu"]), Convert.ToString(ore["kodLotniskaPrzylotu"]), Convert.ToDouble(ore["cenaBiletu"]), Convert.ToInt32(ore["iloscMiejsc"]), Convert.ToString(ore["Obraz"])));
                if (Convert.ToString(ore["Przewoznik"]) == "1")
                    this.listaLotow.Add(new LotModel(Convert.ToInt32(ore["Id"]), Models.Przewoznik.EnterAir, Convert.ToDateTime(ore["czasWylotu"]), Convert.ToDateTime(ore["czasPrzylotu"]), Convert.ToString(ore["miejsceWylotu"]), Convert.ToString(ore["miejscePrzylotu"]), Convert.ToString(ore["kodLotniskaWylotu"]), Convert.ToString(ore["kodLotniskaPrzylotu"]), Convert.ToDouble(ore["cenaBiletu"]), Convert.ToInt32(ore["iloscMiejsc"]), Convert.ToString(ore["Obraz"])));
                if (Convert.ToString(ore["Przewoznik"]) == "3")
                    this.listaLotow.Add(new LotModel(Convert.ToInt32(ore["Id"]), Models.Przewoznik.Lufthansa, Convert.ToDateTime(ore["czasWylotu"]), Convert.ToDateTime(ore["czasPrzylotu"]), Convert.ToString(ore["miejsceWylotu"]), Convert.ToString(ore["miejscePrzylotu"]), Convert.ToString(ore["kodLotniskaWylotu"]), Convert.ToString(ore["kodLotniskaPrzylotu"]), Convert.ToDouble(ore["cenaBiletu"]), Convert.ToInt32(ore["iloscMiejsc"]), Convert.ToString(ore["Obraz"])));
                if (Convert.ToString(ore["Przewoznik"]) == "0")
                    this.listaLotow.Add(new LotModel(Convert.ToInt32(ore["Id"]), Models.Przewoznik.Ryanair, Convert.ToDateTime(ore["czasWylotu"]), Convert.ToDateTime(ore["czasPrzylotu"]), Convert.ToString(ore["miejsceWylotu"]), Convert.ToString(ore["miejscePrzylotu"]), Convert.ToString(ore["kodLotniskaWylotu"]), Convert.ToString(ore["kodLotniskaPrzylotu"]), Convert.ToDouble(ore["cenaBiletu"]), Convert.ToInt32(ore["iloscMiejsc"]), Convert.ToString(ore["Obraz"])));
                if (Convert.ToString(ore["Przewoznik"]) == "4")
                    this.listaLotow.Add(new LotModel(Convert.ToInt32(ore["Id"]), Models.Przewoznik.TurkishAirlines, Convert.ToDateTime(ore["czasWylotu"]), Convert.ToDateTime(ore["czasPrzylotu"]), Convert.ToString(ore["miejsceWylotu"]), Convert.ToString(ore["miejscePrzylotu"]), Convert.ToString(ore["kodLotniskaWylotu"]), Convert.ToString(ore["kodLotniskaPrzylotu"]), Convert.ToDouble(ore["cenaBiletu"]), Convert.ToInt32(ore["iloscMiejsc"]), Convert.ToString(ore["Obraz"])));

            }
            con.Close();
           
            return listaLotow.FirstOrDefault(l => l.Id == id);
        }

        public List<LotModel> getLoty()
        {
            listaLotow.Clear();
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=DbForEFdemo; Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from [dbo].[LotyModel]", con);
            SqlDataReader ore = cmd.ExecuteReader();
            while (ore.Read())
            {
                if (Convert.ToString(ore["Przewoznik"]) =="2")
                    this.listaLotow.Add(new LotModel(Convert.ToInt32(ore["Id"]), Models.Przewoznik.LOT, Convert.ToDateTime(ore["czasWylotu"]), Convert.ToDateTime(ore["czasPrzylotu"]), Convert.ToString(ore["miejsceWylotu"]), Convert.ToString(ore["miejscePrzylotu"]), Convert.ToString(ore["kodLotniskaWylotu"]), Convert.ToString(ore["kodLotniskaPrzylotu"]), Convert.ToDouble(ore["cenaBiletu"]), Convert.ToInt32(ore["iloscMiejsc"]), Convert.ToString(ore["Obraz"])));
                if (Convert.ToString(ore["Przewoznik"]) == "1")
                    this.listaLotow.Add(new LotModel(Convert.ToInt32(ore["Id"]), Models.Przewoznik.EnterAir, Convert.ToDateTime(ore["czasWylotu"]), Convert.ToDateTime(ore["czasPrzylotu"]), Convert.ToString(ore["miejsceWylotu"]), Convert.ToString(ore["miejscePrzylotu"]), Convert.ToString(ore["kodLotniskaWylotu"]), Convert.ToString(ore["kodLotniskaPrzylotu"]), Convert.ToDouble(ore["cenaBiletu"]), Convert.ToInt32(ore["iloscMiejsc"]), Convert.ToString(ore["Obraz"])));
                if (Convert.ToString(ore["Przewoznik"]) == "3")
                    this.listaLotow.Add(new LotModel(Convert.ToInt32(ore["Id"]), Models.Przewoznik.Lufthansa, Convert.ToDateTime(ore["czasWylotu"]), Convert.ToDateTime(ore["czasPrzylotu"]), Convert.ToString(ore["miejsceWylotu"]), Convert.ToString(ore["miejscePrzylotu"]), Convert.ToString(ore["kodLotniskaWylotu"]), Convert.ToString(ore["kodLotniskaPrzylotu"]), Convert.ToDouble(ore["cenaBiletu"]), Convert.ToInt32(ore["iloscMiejsc"]), Convert.ToString(ore["Obraz"])));
                if (Convert.ToString(ore["Przewoznik"]) == "0")
                    this.listaLotow.Add(new LotModel(Convert.ToInt32(ore["Id"]), Models.Przewoznik.Ryanair, Convert.ToDateTime(ore["czasWylotu"]), Convert.ToDateTime(ore["czasPrzylotu"]), Convert.ToString(ore["miejsceWylotu"]), Convert.ToString(ore["miejscePrzylotu"]), Convert.ToString(ore["kodLotniskaWylotu"]), Convert.ToString(ore["kodLotniskaPrzylotu"]), Convert.ToDouble(ore["cenaBiletu"]), Convert.ToInt32(ore["iloscMiejsc"]), Convert.ToString(ore["Obraz"])));
                if (Convert.ToString(ore["Przewoznik"]) == "4")
                    this.listaLotow.Add(new LotModel(Convert.ToInt32(ore["Id"]), Models.Przewoznik.TurkishAirlines, Convert.ToDateTime(ore["czasWylotu"]), Convert.ToDateTime(ore["czasPrzylotu"]), Convert.ToString(ore["miejsceWylotu"]), Convert.ToString(ore["miejscePrzylotu"]), Convert.ToString(ore["kodLotniskaWylotu"]), Convert.ToString(ore["kodLotniskaPrzylotu"]), Convert.ToDouble(ore["cenaBiletu"]), Convert.ToInt32(ore["iloscMiejsc"]), Convert.ToString(ore["Obraz"])));
                
                }
            con.Close();
            return listaLotow;
        }

        public void updateLot(LotModel lot)
        {
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=DbForEFdemo; Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from [dbo].[LotyModel]", con);
            SqlDataReader ore = cmd.ExecuteReader();
            while (ore.Read())
            {
                if (Convert.ToString(ore["Przewoznik"]) == "2")
                    this.listaLotow.Add(new LotModel(Convert.ToInt32(ore["Id"]), Models.Przewoznik.LOT, Convert.ToDateTime(ore["czasWylotu"]), Convert.ToDateTime(ore["czasPrzylotu"]), Convert.ToString(ore["miejsceWylotu"]), Convert.ToString(ore["miejscePrzylotu"]), Convert.ToString(ore["kodLotniskaWylotu"]), Convert.ToString(ore["kodLotniskaPrzylotu"]), Convert.ToDouble(ore["cenaBiletu"]), Convert.ToInt32(ore["iloscMiejsc"]), Convert.ToString(ore["Obraz"])));
                if (Convert.ToString(ore["Przewoznik"]) == "1")
                    this.listaLotow.Add(new LotModel(Convert.ToInt32(ore["Id"]), Models.Przewoznik.EnterAir, Convert.ToDateTime(ore["czasWylotu"]), Convert.ToDateTime(ore["czasPrzylotu"]), Convert.ToString(ore["miejsceWylotu"]), Convert.ToString(ore["miejscePrzylotu"]), Convert.ToString(ore["kodLotniskaWylotu"]), Convert.ToString(ore["kodLotniskaPrzylotu"]), Convert.ToDouble(ore["cenaBiletu"]), Convert.ToInt32(ore["iloscMiejsc"]), Convert.ToString(ore["Obraz"])));
                if (Convert.ToString(ore["Przewoznik"]) == "3")
                    this.listaLotow.Add(new LotModel(Convert.ToInt32(ore["Id"]), Models.Przewoznik.Lufthansa, Convert.ToDateTime(ore["czasWylotu"]), Convert.ToDateTime(ore["czasPrzylotu"]), Convert.ToString(ore["miejsceWylotu"]), Convert.ToString(ore["miejscePrzylotu"]), Convert.ToString(ore["kodLotniskaWylotu"]), Convert.ToString(ore["kodLotniskaPrzylotu"]), Convert.ToDouble(ore["cenaBiletu"]), Convert.ToInt32(ore["iloscMiejsc"]), Convert.ToString(ore["Obraz"])));
                if (Convert.ToString(ore["Przewoznik"]) == "0")
                    this.listaLotow.Add(new LotModel(Convert.ToInt32(ore["Id"]), Models.Przewoznik.Ryanair, Convert.ToDateTime(ore["czasWylotu"]), Convert.ToDateTime(ore["czasPrzylotu"]), Convert.ToString(ore["miejsceWylotu"]), Convert.ToString(ore["miejscePrzylotu"]), Convert.ToString(ore["kodLotniskaWylotu"]), Convert.ToString(ore["kodLotniskaPrzylotu"]), Convert.ToDouble(ore["cenaBiletu"]), Convert.ToInt32(ore["iloscMiejsc"]), Convert.ToString(ore["Obraz"])));
                if (Convert.ToString(ore["Przewoznik"]) == "4")
                    this.listaLotow.Add(new LotModel(Convert.ToInt32(ore["Id"]), Models.Przewoznik.TurkishAirlines, Convert.ToDateTime(ore["czasWylotu"]), Convert.ToDateTime(ore["czasPrzylotu"]), Convert.ToString(ore["miejsceWylotu"]), Convert.ToString(ore["miejscePrzylotu"]), Convert.ToString(ore["kodLotniskaWylotu"]), Convert.ToString(ore["kodLotniskaPrzylotu"]), Convert.ToDouble(ore["cenaBiletu"]), Convert.ToInt32(ore["iloscMiejsc"]), Convert.ToString(ore["Obraz"])));

            }
            con.Close();
            int idx = listaLotow.FindIndex(l => l.Id == lot.Id);
            if (idx >= 0)
            {
                listaLotow.ElementAt(idx).miejscePrzylotu = lot.miejscePrzylotu;
                listaLotow.ElementAt(idx).miejsceWylotu = lot.miejsceWylotu;
                listaLotow.ElementAt(idx).iloscMiejsc = lot.iloscMiejsc;
                listaLotow.ElementAt(idx).czasPrzylotu = lot.czasPrzylotu;
                listaLotow.ElementAt(idx).czasWylotu = lot.czasWylotu;
                listaLotow.ElementAt(idx).kodLotniskaPrzylotu = lot.kodLotniskaPrzylotu;
                listaLotow.ElementAt(idx).kodLotniskaWylotu = lot.kodLotniskaWylotu;
                listaLotow.ElementAt(idx).cenaBiletu = lot.cenaBiletu;
            }
        }
    }
}
