using System.Collections.Immutable;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Versioning;

Dictionary<string, Tuple<string, int>> igraci = new Dictionary<string, Tuple<string, int>>();
Tuple<string, int> t1 = new Tuple<string, int>("MF", 88);
igraci.Add("Luka Modric", t1);
Tuple<string, int> t2 = new Tuple<string, int>("MF", 86);
igraci.Add("Marcelo Brozovic", t2);
Tuple<string, int> t3 = new Tuple<string, int>("MF", 84);
igraci.Add("Mateo Kovacic", t3);
Tuple<string, int> t4 = new Tuple<string, int>("MF", 84);
igraci.Add("Ivan Perisic", t2);
Tuple<string, int> t5 = new Tuple<string, int>("FW", 82);
igraci.Add("Andrej Kramric", t2);
Tuple<string, int> t6 = new Tuple<string, int>("MF", 82);
igraci.Add("Ivan Rakitic", t6);
Tuple<string, int> t7 = new Tuple<string, int>("DF", 81);
igraci.Add("Josko Gvardiol", t7);
Tuple<string, int> t8 = new Tuple<string, int>("MF", 81);
igraci.Add("Mario Pasalic", t8);
Tuple<string, int> t9 = new Tuple<string, int>("MF", 81);
igraci.Add("Lovro Majer", t9);
Tuple<string, int> t10 = new Tuple<string, int>("GK", 80);
igraci.Add("Dominik Livakovic", t10);
Tuple<string, int> t11 = new Tuple<string, int>("FW", 80);
igraci.Add("Ante Rebic", t11);
Tuple<string, int> t12 = new Tuple<string, int>("MF", 79);
igraci.Add("Josip Brekalo", t12);
Tuple<string, int> t13 = new Tuple<string, int>("DF", 78);
igraci.Add("Borna Sosa", t13);
Tuple<string, int> t14 = new Tuple<string, int>("MF", 78);
igraci.Add("Nikola Vlasic", t14);
Tuple<string, int> t15 = new Tuple<string, int>("DF", 78);
igraci.Add("Duje Caleta-Car", t15);
Tuple<string, int> t16 = new Tuple<string, int>("DF", 78);
igraci.Add("Dejan Lovren", t16);
Tuple<string, int> t17 = new Tuple<string, int>("FW", 77);
igraci.Add("Mislav Orsic", t17);
Tuple<string, int> t18 = new Tuple<string, int>("FW", 77);
igraci.Add("Marko Livaja", t18);
Tuple<string, int> t19 = new Tuple<string, int>("DF", 76);
igraci.Add("Domagoj Vida", t19);
Tuple<string, int> t20 = new Tuple<string, int>("FW", 76);
igraci.Add("Ante Budimir", t20);

List<int> MB = new List<int>() { 0, 0, 0 };
List<int> MK = new List<int>() { 0, 0, 0 };
List<int> KB = new List<int>() { 0, 0, 0 };
List<int> MH = new List<int>() { 0, 0, 0 };
List<int> KH = new List<int>() { 0, 0, 0 };
List<int> BH = new List<int>() { 0, 0, 0 };

int goloviRazlikeMaroko = 0;
int goloviRazlikeKanada = 0;
int goloviRazlikeBelgija = 0;
int goloviRazlikeHrvatska = 0;

int brojBodovaMaroko = 0;
int brojBodovaKanada = 0;
int brojBodovaBelgija = 0;
int brojBodovaHrvatska = 0;
void izlazIzAplikacije()
{
    Console.Clear();

}

void rezultatiUtakmice()
{
    if (MB[2] == 0)
        Console.WriteLine("Maroko-Belgija: nije odigrana");
    else
        Console.WriteLine("Maroko-Belgija: {0}-{1}", MB[0], MB[1]);
    if (MK[2] == 0)
        Console.WriteLine("Maroko-Kanada: nije odigrana");
    else
        Console.WriteLine("Maroko-Kanada: {0}-{1}", MK[0], MK[1]);
    if (KB[2] == 0)
        Console.WriteLine("Kanada-Belgija: nije odigrana");
    else
        Console.WriteLine("Kanada-Belgija: {0}-{1}", KB[0], KB[1]);
    if (MH[2] == 0)
        Console.WriteLine("Maroko-Hrvatska: nije odigrana");
    else
        Console.WriteLine("Maroko-Hrvatska: {0}-{1}", MH[0], MH[1]);
    if (KH[2] == 0)
        Console.WriteLine("Kanada-Hrvatska: nije odigrana");
    else
        Console.WriteLine("Kanada-Hrvatska: {0}-{1}", KH[0], KH[1]);
    if (BH[2] == 0)
        Console.WriteLine("Belgija-Hrvatska: nije odigrana");
    else
        Console.WriteLine("Belgija-Hrvatksa: {0}-{1}", BH[0], BH[1]);

}
List<string> najboljih11()
{
    Random rdn = new Random();
    List<string> list = new List<string>();
    List<string> DF = new List<string>();
    List<string> MF = new List<string>();
    List<string> FW = new List<string>();
    List<string> GK = new List<string>();

    foreach (var k in igraci.Keys)
    {
        if (igraci[k].Item1 == "GK")
            GK.Add(k);
        if (igraci[k].Item1 == "DF")
            DF.Add(k);
        if (igraci[k].Item1 == "MF")
            MF.Add(k);
        if (igraci[k].Item1 == "FW")
            FW.Add(k);
    }

    for (int j = 1; j < 2; j++)
    {
        string max = GK[0];
        for (int i = 0; i < GK.Count; i++)
        {
            if (igraci[max].Item2 <= igraci[GK[i]].Item2)
                max = GK[i];
        }
        list.Add(max);
        GK.Remove(max);
    }
    for (int j = 1; j < 5; j++)
    {
        string max = DF[0];
        for (int i = 0; i < DF.Count; i++)
        {
            if (igraci[max].Item2 <= igraci[DF[i]].Item2)
                max = DF[i];
        }
        list.Add(max);
        DF.Remove(max);
    }
    for (int j = 1; j < 4; j++)
    {
        string max1 = MF[0];
        for (int i = 0; i < MF.Count; i++)
        {
            if (igraci[max1].Item2 <= igraci[MF[i]].Item2)
                max1 = MF[i];
        }
        list.Add(max1);
        MF.Remove(max1);
    }
    for (int j = 1; j < 4; j++)
    {
        string max2 = FW[0];
        for (int i = 0; i < FW.Count; i++)
        {
            if (igraci[max2].Item2 <= igraci[FW[i]].Item2)
                max2 = FW[i];
        }
        list.Add(max2);
        FW.Remove(max2);
    }
    GK.Clear();
    MF.Clear();
    FW.Clear();
    DF.Clear();
    return list;
}
Dictionary<string, int> strijelci = new Dictionary<string, int>();
void izbornik()
{
    Console.WriteLine("1 - Odradi trening");
    Console.WriteLine("2 - Odigraj utakmicu");
    Console.WriteLine("3 - Statistika");
    Console.WriteLine("4 - Kontrola igraca");
    Console.WriteLine("0 - Izlaz iz aplikacije");
    string unos;
    int odabir;
    do
    {
        Console.WriteLine("Odaberi: 0, 1, 2, 3, 4");
        unos = Console.ReadLine();
    } while (unos != "0" && unos != "1" && unos != "2" && unos != "3" && unos != "4");
    odabir = int.Parse(unos);
    switch (odabir)
    {
        case 0:
            izlazIzAplikacije();
            break;
        case 1:
            odradiTrening();
            break;
        case 2:
            odigrajUtakmicu();
            break;
        case 3:
            statistika();
            break;
        case 4:
            kontrolaIgraca();
            break;
    }
}

List<int> dvaRandomBroja()
{
    Random rdn = new Random();
    List<int> l = new List<int>() { rdn.Next(0, 6), rdn.Next(0, 6), 1 };
    return l;
}
void odradiTrening()
{
    Random rdn = new Random();
    int num;
    foreach (var k in igraci.Keys)
    {
        Console.WriteLine(k);
        Console.WriteLine("Stari rating: {0}", igraci[k].Item2);
        num = igraci[k].Item2 + igraci[k].Item2 * rdn.Next(0, 6) / 100;
        Tuple<string, int> t = new Tuple<string, int>(igraci[k].Item1, num);
        igraci[k] = t;
        Console.WriteLine("Novi rating: {0}", igraci[k].Item2);
    }
    izbornik();
}
void odigrajUtakmicu()
{
    Console.WriteLine("Odaberi utakmicu: ");
    Console.WriteLine("1 - Maroko-Belgija");
    Console.WriteLine("2 - Maroko-Kanada");
    Console.WriteLine("3 - Kanada-Belgija");
    Console.WriteLine("4 - Maroko-Hrvatska");
    Console.WriteLine("5 - Kanada-Hrvatska");
    Console.WriteLine("6 - Belgija-Hrvatska");
    Console.WriteLine("7 - Povratak na glavni izbornik");

    string unos1;
    int odabir1;
    do
    {
        Console.WriteLine("Odaberi: 1, 2, 3, 4, 5, 6");
        unos1 = Console.ReadLine();
    } while (unos1 != "0" && unos1 != "1" && unos1 != "2" && unos1 != "3" && unos1 != "4" && unos1 != "5" && unos1 != "6" && unos1 != "7");
    odabir1 = int.Parse(unos1);
    switch (odabir1)
    {
        case 1:
            if (MB[2] == 0)
            {
                MB = dvaRandomBroja();
                rezultatiUtakmice();
                if (MB[0] < MB[1])
                {
                    brojBodovaBelgija += 3;
                    goloviRazlikeBelgija += (MB[1] - MB[0]);
                    goloviRazlikeMaroko += (MB[0] - MB[1]);
                }
                if (MB[0] > MB[1])
                {
                    brojBodovaMaroko += 3;
                    goloviRazlikeBelgija += (MB[1] - MB[0]);
                    goloviRazlikeMaroko += (MB[0] - MB[1]);
                }
                if (MB[0] == MB[1])
                {
                    brojBodovaBelgija += 1;
                    brojBodovaMaroko += 1;
                }
                izbornik();
            }
            else
            {
                Console.WriteLine("Ta utakmica je vec odigrana");
                izbornik();
            }
            break;
        case 2:
            if (MK[2] == 0)
            {
                MK = dvaRandomBroja();
                rezultatiUtakmice();
                if (MK[0] < MK[1])
                {
                    brojBodovaKanada += 3;
                    goloviRazlikeKanada += (MK[1] - MK[0]);
                    goloviRazlikeMaroko += (MK[0] - MK[1]);
                }
                if (MK[0] > MK[1])
                {
                    brojBodovaMaroko += 3;
                    goloviRazlikeKanada += (MK[1] - MK[0]);
                    goloviRazlikeMaroko += (MK[0] - MK[1]);
                }
                if (MK[0] == MK[1])
                {
                    brojBodovaKanada += 1;
                    brojBodovaMaroko += 1;
                }
                izbornik();
            }
            else
            {
                Console.WriteLine("Ta utakmica je vec odigrana");
                izbornik();
            }
            break;
        case 3:
            if (KB[2] == 0)
            {
                KB = dvaRandomBroja();
                rezultatiUtakmice();
                if (KB[0] < KB[1])
                {
                    brojBodovaBelgija += 3;
                    goloviRazlikeBelgija += (KB[1] - KB[0]);
                    goloviRazlikeKanada += (KB[0] - KB[1]);
                }
                if (KB[0] > KB[1])
                {
                    brojBodovaKanada += 3;
                    goloviRazlikeBelgija += (KB[1] - KB[0]);
                    goloviRazlikeKanada += (KB[0] - KB[1]);
                }
                if (KB[0] == KB[1])
                {
                    brojBodovaKanada += 1;
                    brojBodovaBelgija += 1;
                }
                izbornik();
            }
            else
            {
                Console.WriteLine("Ta utakmica je vec odigrana");
                izbornik();
            }
            break;
        case 4:
            if (igraci.Count < 11)
            {
                Console.WriteLine("Nema dovoljno igraca");
                izbornik();
            }
            else
            {
                if (MH[2] == 0)
                {
                    MH = dvaRandomBroja();
                    rezultatiUtakmice();
                    izbornik();
                    Random rdn1 = new Random();
                    List<string> igraciUtakmice = new List<string>();
                    igraciUtakmice = najboljih11();
                    int goloviHrvatska = MH[1];
                    int goloviMaroko = MH[0];
                    for (int j = 0; j < goloviHrvatska; j++)
                    {
                        string strijelac = igraciUtakmice[rdn1.Next(0, 11)];
                        int noviRating = igraci[strijelac].Item2 + igraci[igraciUtakmice[rdn1.Next(0, 11)]].Item2 * 5 / 100;
                        Tuple<string, int> t21 = new Tuple<string, int>(igraci[strijelac].Item1, noviRating);
                        igraci[strijelac] = t21;
                        if (strijelci.ContainsKey(strijelac))
                            strijelci[strijelac]++;
                        else
                        {
                            strijelci.Add(strijelac, 1);
                        }
                    }
                    if (goloviHrvatska < goloviMaroko)
                    {
                        for (int j = 0; j < 11; j++)
                        {
                            int noviRating = igraci[igraciUtakmice[j]].Item2 - igraci[igraciUtakmice[j]].Item2 * 2 / 100;
                            Tuple<string, int> t21 = new Tuple<string, int>(igraci[igraciUtakmice[j]].Item1, noviRating);
                            igraci[igraciUtakmice[j]] = t21;
                        }
                    }
                    if (goloviHrvatska > goloviMaroko)
                    {
                        for (int j = 0; j < 11; j++)
                        {
                            int noviRating = igraci[igraciUtakmice[j]].Item2 + igraci[igraciUtakmice[j]].Item2 * 2 / 100;
                            Tuple<string, int> t21 = new Tuple<string, int>(igraci[igraciUtakmice[j]].Item1, noviRating);
                            igraci[igraciUtakmice[j]] = t21;
                        }
                    }

                    if (MH[0] < MH[1])
                    {
                        brojBodovaHrvatska += 3;
                        goloviRazlikeHrvatska += (MH[1] - MH[0]);
                        goloviRazlikeMaroko += (MH[0] - MH[1]);
                    }
                    if (MH[0] > MH[1])
                    {
                        brojBodovaMaroko += 3;
                        goloviRazlikeHrvatska += (MH[1] - MH[0]);
                        goloviRazlikeMaroko += (MH[0] - MH[1]);
                    }
                    if (MH[0] == MH[1])
                    {
                        brojBodovaHrvatska += 1;
                        brojBodovaMaroko += 1;
                    }
                }
                else
                {
                    Console.WriteLine("Ta utakmica je vec odigrana");
                    izbornik();
                }
            }
            break;
        case 5:
            if (igraci.Count < 11)
            {
                Console.WriteLine("Nema dovoljno igraca");
                izbornik();
            }
            else
            {
                if (KH[2] == 0)
                {
                    KH = dvaRandomBroja();
                    rezultatiUtakmice();
                    izbornik();
                    Random rdn2 = new Random();
                    List<string> igraciUtakmice = new List<string>();
                    igraciUtakmice = najboljih11();
                    int goloviHrvatska = KH[1];
                    int goloviKanada = KH[0];
                    for (int j = 0; j < goloviHrvatska; j++)
                    {
                        string strijelac = igraciUtakmice[rdn2.Next(0, 11)];
                        int noviRating = igraci[strijelac].Item2 + igraci[igraciUtakmice[rdn2.Next(0, 11)]].Item2 * 5 / 100;
                        Tuple<string, int> t21 = new Tuple<string, int>(igraci[strijelac].Item1, noviRating);
                        igraci[strijelac] = t21;
                        if (strijelci.ContainsKey(strijelac))
                            strijelci[strijelac]++;
                        else
                            strijelci.Add(strijelac, 1);
                    }
                    if (goloviHrvatska < goloviKanada)
                    {
                        for (int j = 0; j < 11; j++)
                        {
                            int noviRating = igraci[igraciUtakmice[j]].Item2 - igraci[igraciUtakmice[j]].Item2 * 2 / 100;
                            Tuple<string, int> t21 = new Tuple<string, int>(igraci[igraciUtakmice[j]].Item1, noviRating);
                            igraci[igraciUtakmice[j]] = t21;
                        }
                    }
                    if (goloviHrvatska > goloviKanada)
                    {
                        for (int j = 0; j < 11; j++)
                        {
                            int noviRating = igraci[igraciUtakmice[j]].Item2 + igraci[igraciUtakmice[j]].Item2 * 2 / 100;
                            Tuple<string, int> t21 = new Tuple<string, int>(igraci[igraciUtakmice[j]].Item1, noviRating);
                            igraci[igraciUtakmice[j]] = t21;
                        }
                    }

                    if (KH[0] < KH[1])
                    {
                        brojBodovaHrvatska += 3;
                        goloviRazlikeHrvatska += (KH[1] - KH[0]);
                        goloviRazlikeKanada += (KH[0] - KH[1]);
                    }
                    if (KH[0] > KH[1])
                    {
                        brojBodovaKanada += 3;
                        goloviRazlikeHrvatska += (KH[1] - KH[0]);
                        goloviRazlikeKanada += (KH[0] - KH[1]);
                    }
                    if (KH[0] == KH[1])
                    {
                        brojBodovaHrvatska += 1;
                        brojBodovaKanada += 1;
                    }
                }
                else
                {
                    Console.WriteLine("Ta utakmica je vec odigrana");
                    izbornik();
                }
            }
            break;
        case 6:
            if (igraci.Count < 11)
            {
                Console.WriteLine("Nema dovoljno igraca");
                izbornik();
            }
            else
            {
                if (BH[2] == 0)
                {
                    BH = dvaRandomBroja();
                    rezultatiUtakmice();
                    izbornik();
                    Random rdn3 = new Random();
                    List<string> igraciUtakmice = new List<string>();
                    igraciUtakmice = najboljih11();
                    int goloviHrvatska = BH[1];
                    int goloviBelgija = BH[0];
                    for (int j = 0; j < goloviHrvatska; j++)
                    {
                        string strijelac = igraciUtakmice[rdn3.Next(0, 11)];
                        int noviRating = igraci[strijelac].Item2 + igraci[igraciUtakmice[rdn3.Next(0, 11)]].Item2 * 5 / 100;
                        Tuple<string, int> t21 = new Tuple<string, int>(igraci[strijelac].Item1, noviRating);
                        igraci[strijelac] = t21;
                        if (strijelci.ContainsKey(strijelac))
                            strijelci[strijelac]++;
                        else
                            strijelci.Add(strijelac, 1);
                    }
                    if (goloviHrvatska < goloviBelgija)
                    {
                        for (int j = 0; j < 11; j++)
                        {
                            int noviRating = igraci[igraciUtakmice[j]].Item2 - igraci[igraciUtakmice[j]].Item2 * (2 / 100);
                            Tuple<string, int> t21 = new Tuple<string, int>(igraci[igraciUtakmice[j]].Item1, noviRating);
                            igraci[igraciUtakmice[j]] = t21;
                        }
                    }
                    if (goloviHrvatska > goloviBelgija)
                    {
                        for (int j = 0; j < 11; j++)
                        {
                            int noviRating = igraci[igraciUtakmice[j]].Item2 + igraci[igraciUtakmice[j]].Item2 * 2 / 100;
                            Tuple<string, int> t21 = new Tuple<string, int>(igraci[igraciUtakmice[j]].Item1, noviRating);
                            igraci[igraciUtakmice[j]] = t21;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Ta utakmica je vec odigrana");
                    izbornik();
                }
                if (BH[0] < BH[1])
                {
                    brojBodovaHrvatska += 3;
                    goloviRazlikeHrvatska += (BH[1] - BH[0]);
                    goloviRazlikeBelgija += (BH[0] - BH[1]);
                }
                if (BH[0] > BH[1])
                {
                    goloviRazlikeBelgija += 3;
                    goloviRazlikeHrvatska += (BH[1] - BH[0]);
                    goloviRazlikeBelgija += (BH[0] - BH[1]);
                }
                if (BH[0] == BH[1])
                {
                    brojBodovaHrvatska += 1;
                    brojBodovaBelgija += 1;
                }
            }
            break;
        case 7:
            Console.Clear();
            izbornik();
            break;
        default: { break; }
    }

}
void statistika()
{
    Console.WriteLine("Odaberi: ");
    Console.WriteLine("1 - Ispis onako kako su spremljeni");
    Console.WriteLine("2 - Ispis po ratingu uzlazno");
    Console.WriteLine("3 - Ispis po ratingu silazno");
    Console.WriteLine("4 - Ispis igraca po imenu i prezimenu(ispis pozicije i ratinga)");
    Console.WriteLine("5 - Ispis po ratingu");
    Console.WriteLine("6 - Ispis po poziciji");
    Console.WriteLine("7 - Ispis trenutno prvih 11 igraca");
    Console.WriteLine("8 - Ispis strijelaca i koliko golova imaju");
    Console.WriteLine("9 - Ispis svih rezultata ekipe");
    Console.WriteLine("10 - Ispis rezultat svih ekipa");
    Console.WriteLine("11 - Ispis tablice grupe(mjesto na tablici, ime ekipe, broj bodova, gol razlika");
    Console.WriteLine("12 - Povratak na glavni izbornik");

    string unos2;
    int odabir2;
    do
    {
        Console.WriteLine("Odaberi: 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12");
        unos2 = Console.ReadLine();
    } while (unos2 != "1" && unos2 != "2" && unos2 != "3" && unos2 != "4" && unos2 != "5" && unos2 != "6" && unos2 != "7" && unos2 != "8" && unos2 != "9" && unos2 != "10" && unos2 != "11" && unos2 != "12");
    odabir2 = int.Parse(unos2);
    switch (odabir2)
    {
        case 1:
            foreach (var k in igraci.Keys)
                Console.WriteLine(k);
            break;
        case 2:
            var sortedigraciuzlazno = igraci.OrderBy(k => k.Value.Item2);
            foreach (var item in sortedigraciuzlazno)
                Console.WriteLine(item);
            break;
        case 3:
            var sortedigracisilazno = igraci.OrderByDescending(k => k.Value.Item2);
            foreach (var item in sortedigracisilazno)
                Console.WriteLine(item);
            break;
        case 4:
            Console.WriteLine("Upisi ime igraca ");
            string imeigraca = Console.ReadLine();
            if (igraci.ContainsKey(imeigraca))
                Console.WriteLine(igraci[imeigraca].Item1 + igraci[imeigraca].Item2.ToString());
            else
            {
                Console.WriteLine("ne postoji igrac s takvim imenom");
                izbornik();
            }
            break;
        case 5:
            Console.WriteLine("Upisi rating igraca ");
            int ratingIgraca = int.Parse(Console.ReadLine());
            foreach (var k in igraci.Keys)
            {
                if (igraci[k].Item2 == ratingIgraca)
                    Console.WriteLine(k);
            }
            break;
        case 6:
            Console.WriteLine("Upisi poziciju igraca ");
            string pozicijaIgraca = Console.ReadLine();
            foreach (var k in igraci.Keys)
            {
                if (igraci[k].Item1 == pozicijaIgraca)
                    Console.WriteLine(k);
            }
            break;
        case 7:
            List<string> trenutni11 = new List<string>();
            trenutni11 = najboljih11();
            foreach (var item in trenutni11)
                Console.WriteLine(item);
            break;
        case 8:
            foreach (string k in strijelci.Keys)
            {
                Console.WriteLine(k);
                Console.WriteLine(strijelci[k]);
            }
            break;
        case 9:
            Console.WriteLine("Izaberi: ");
            Console.WriteLine("1 - Maroko");
            Console.WriteLine("2 - Kanada");
            Console.WriteLine("3 - Belgija");
            Console.WriteLine("4 - Hrvatska");
            Console.WriteLine("5 - Povratak na glavni izbornik");
            string unos3;
            int odabir3;
            do
            {
                Console.WriteLine("Odaberi: 1, 2, 3, 4, 5");
                unos3 = Console.ReadLine();
            } while (unos3 != "1" && unos3 != "2" && unos3 != "3" && unos3 != "4" && unos3 != "5");
            odabir3 = int.Parse(unos3);
            if (odabir3 == 1)
            {
                if (MB[2] == 0)
                    Console.WriteLine("Maroko-Belgija: nije odigrana");
                else
                    Console.WriteLine("Maroko-Belgija: {0}-{1}", MB[0], MB[1]);
                if (MK[2] == 0)
                    Console.WriteLine("Maroko-Kanada: nije odigrana");
                else
                    Console.WriteLine("Maroko-Kanada: {0}-{1}", MK[0], MK[1]);
                if (MH[2] == 0)
                    Console.WriteLine("Maroko-Hrvatska: nije odigrana");
                else
                    Console.WriteLine("Maroko-Hrvatska: {0}-{1}", MH[0], MH[1]);
            }
            if (odabir3 == 2)
            {
                if (MK[2] == 0)
                    Console.WriteLine("Maroko-Kanada: nije odigrana");
                else
                    Console.WriteLine("Maroko-Kanada: {0}-{1}", MK[0], MK[1]);
                if (KB[2] == 0)
                    Console.WriteLine("Kanada-Belgija: nije odigrana");
                else
                    Console.WriteLine("Kanada-Belgija: {0}-{1}", KB[0], KB[1]);
                if (KH[2] == 0)
                    Console.WriteLine("Kanada-Hrvatska: nije odigrana");
                else
                    Console.WriteLine("Kanada-Hrvatska: {0}-{1}", KH[0], KH[1]);
            }
            if (odabir3 == 3)
            {
                if (MB[2] == 0)
                    Console.WriteLine("Maroko-Belgija: nije odigrana");
                else
                    Console.WriteLine("Maroko-Belgija: {0}-{1}", MB[0], MB[1]);
                if (KB[2] == 0)
                    Console.WriteLine("Kanada-Belgija: nije odigrana");
                else
                    Console.WriteLine("Kanada-Belgija: {0}-{1}", KB[0], KB[1]);
                if (BH[2] == 0)
                    Console.WriteLine("Belgija-Hrvatska: nije odigrana");
                else
                    Console.WriteLine("Belgija-Hrvatksa: {0}-{1}", BH[0], BH[1]);
            }
            if (odabir3 == 4)
            {
                if (MH[2] == 0)
                    Console.WriteLine("Maroko-Hrvatska: nije odigrana");
                else
                    Console.WriteLine("Maroko-Hrvatska: {0}-{1}", MH[0], MH[1]);
                if (KH[2] == 0)
                    Console.WriteLine("Kanada-Hrvatska: nije odigrana");
                else
                    Console.WriteLine("Kanada-Hrvatska: {0}-{1}", KH[0], KH[1]);
                if (BH[2] == 0)
                    Console.WriteLine("Belgija-Hrvatska: nije odigrana");
                else
                    Console.WriteLine("Belgija-Hrvatksa: {0}-{1}", BH[0], BH[1]);
            }
            if (odabir3 == 5)
            {
                Console.Clear();
                izbornik();

            }
            break;
        case 10:
            rezultatiUtakmice();
            break;
        case 11:
            Console.WriteLine("Izaberi: ");
            Console.WriteLine("1 - Maroko");
            Console.WriteLine("2 - Kanada");
            Console.WriteLine("3 - Belgija");
            Console.WriteLine("4 - Hrvatska");
            Console.WriteLine("5 - Povratak na glavni izbornik");
            string unos4;
            int odabir4;
            do
            {
                Console.WriteLine("Odaberi: 1, 2, 3, 4, 5");
                unos4 = Console.ReadLine();
            } while (unos4 != "1" && unos4 != "2" && unos4 != "3" && unos4 != "4" && unos4 != "5");
            odabir4 = int.Parse(unos4);

            if (odabir4 == 1)
            {
                Console.WriteLine("Maroko: ");
                Console.WriteLine("broj bodova: {0}", brojBodovaMaroko);
                Console.WriteLine("razlika golova: ", goloviRazlikeMaroko);
            }
            if (odabir4 == 2)
            {
                Console.WriteLine("Kanada: ");
                Console.WriteLine("broj bodova: {0}", brojBodovaKanada);
                Console.WriteLine("razlika golova: ", goloviRazlikeKanada);
            }
            if (odabir4 == 3)
            {
                Console.WriteLine("Belgija: ");
                Console.WriteLine("broj bodova: {0}", brojBodovaBelgija);
                Console.WriteLine("razlika golova: ", goloviRazlikeBelgija);
            }
            if (odabir4 == 4)
            {
                Console.WriteLine("Hrvatska: ");
                Console.WriteLine("broj bodova: {0}", brojBodovaHrvatska);
                Console.WriteLine("razlika golova: ", goloviRazlikeHrvatska);
            }
            if (odabir4 == 5)
            {
                Console.Clear();
                izbornik();

            }
            break;
        case 12:
            Console.Clear();
            izbornik();
            break;
        default: { break; }
    }


}
void kontrolaIgraca()
{
    Console.WriteLine("Odaberi: ");
    Console.WriteLine("1 - Unos novog igraca");
    Console.WriteLine("2 - Brisanje igraca unosom imena i prezimena");
    Console.WriteLine("3 - Uredivanje igraca");
    Console.WriteLine("0 - Izlaz iz aplikacije");

    string unos3;
    int odabir3;
    do
    {
        Console.WriteLine("Odaberi: 1, 2, 3, 4");
        unos3 = Console.ReadLine();
    } while (unos3 != "1" && unos3 != "2" && unos3 != "3" && unos3 != "0");
    odabir3 = int.Parse(unos3);
    switch (odabir3)
    {
        case 1:
            string noviIgrac, izmjenaImena, stariIgrac;
            string novaPozicija;
            int noviRating;
            if (igraci.Count == 26)
            {
                Console.WriteLine("Igraca vec ima dovoljno.");
                izbornik();
            }
            else
            {
                do
                {
                    Console.WriteLine("Unesite ime novog igraca: ");
                    noviIgrac = Console.ReadLine();
                }
                while (igraci.ContainsKey(noviIgrac) || noviIgrac == " ");
                do
                {
                    Console.WriteLine("Unesite poziciju novog igraca: ");
                    novaPozicija = Console.ReadLine();
                }
                while (novaPozicija != "GK" && novaPozicija != "FW" && novaPozicija != "DF" && novaPozicija != "MF");
                do
                {
                    Console.WriteLine("Unesite rating novog igraca: ");
                    noviRating = int.Parse(Console.ReadLine());
                }
                while (noviRating < 0 || noviRating > 100);

                Tuple<string, int> t22 = new Tuple<string, int>(novaPozicija, noviRating);
                igraci.Add(noviIgrac, t22);

            }
            break;
        case 2:
            do
            {
                Console.WriteLine("Unesite ime igraca kojeg zelite izbrisati: ");
                noviIgrac = Console.ReadLine();
            }
            while (!igraci.ContainsKey(noviIgrac));
            igraci.Remove(noviIgrac);
            break;
        case 3:
            Console.WriteLine("Odaberi: ");
            Console.WriteLine("1 - Uredivanje imena i prezimena");
            Console.WriteLine("2 - Uredi poziciju");
            Console.WriteLine("3 - Uredi rating (od 1 do 100)");
            Console.WriteLine("4 - Povratak na izbornik");

            string unos4;
            int odabir4;
            do
            {
                Console.WriteLine("Odaberi: 1, 2, 3, 4");
                unos4 = Console.ReadLine();
            } while (unos4 != "1" && unos4 != "2" && unos4 != "3" && unos4 != "0");
            odabir4 = int.Parse(unos4);
            do
            {
                Console.WriteLine("Unesite ime igraca na kojem zelite napraviti izmjene: ");
                stariIgrac = Console.ReadLine();
            }
            while (!igraci.ContainsKey(stariIgrac));
            if (odabir4 == 1)
            {
                do
                {
                    Console.WriteLine("Unesite novo ime i prezime: ");
                    izmjenaImena = Console.ReadLine();
                }
                while (igraci.ContainsKey(izmjenaImena) || izmjenaImena == " ");

                igraci.Add(izmjenaImena, igraci[stariIgrac]);
                igraci.Remove(stariIgrac);

            }
            if (odabir4 == 2)
            {
                do
                {
                    Console.WriteLine("Unesite ime igraca na kojem zelite napraviti izmjene: ");
                    stariIgrac = Console.ReadLine();
                }
                while (!igraci.ContainsKey(stariIgrac));
                do
                {
                    Console.WriteLine("Unesite novu poziciju: ");
                    novaPozicija = Console.ReadLine();
                }
                while (novaPozicija != "GK" && novaPozicija != "FW" && novaPozicija != "DF" && novaPozicija != "MF");
                Tuple<string, int> t23 = new Tuple<string, int>(novaPozicija, igraci[stariIgrac].Item2);
                igraci[stariIgrac] = t23;

            }
            if (odabir4 == 3)
            {
                do
                {
                    Console.WriteLine("Unesite ime igraca na kojem zelite napraviti izmjene: ");
                    stariIgrac = Console.ReadLine();
                }
                while (!igraci.ContainsKey(stariIgrac));
                do
                {
                    Console.WriteLine("Unesite rating novog igraca: ");
                    noviRating = int.Parse(Console.ReadLine());
                }
                while (noviRating < 0 || noviRating > 100);
                Tuple<string, int> t23 = new Tuple<string, int>(igraci[stariIgrac].Item1, noviRating);
                igraci[stariIgrac] = t23;
            }
            if (odabir4 == 4)
            {
                Console.Clear();
                izbornik();
            }
            break;
        case 0:
            izlazIzAplikacije();
            break;
        default: break;
    }
}

izbornik();
