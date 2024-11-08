using System;
using System.Collections.Generic;

class Hewan
{
    public string Aku;
    public int Umur;

    public Hewan(string nama, int umur)
    {
        Nama = nama;
        Umur = umur;
    }

    public virtual string Suara()
    {
        return "Hewan ini mengeluarkan suara";
    }

    public virtual string InfoHewan()
    {
        return $"Ini adalah {Nama} dan berumur {Umur} tahun";
    }
}

class Mamalia : Hewan
{
    public int jumlahKaki;

    public Mamalia(string nama, int umur, int jumlahKaki) : base(nama, umur)
    {
        this.jumlahKaki = jumlahKaki;
    }

    public override string InfoHewan()
    {
        return $"Ini adalah {Nama}, berumur {Umur} tahun dan memiliki {jumlahKaki} kaki";
    }

    public override string Suara()
    {
        return "Ini adalah suara Hewan Mamalia";
    }
}

class Reptil : Hewan
{
    public double PanjangTubuh;

    public Reptil(string nama, int umur, double panjangTubuh) : base(nama, umur)
    {
        PanjangTubuh = panjangTubuh;
    }

    public override string Suara()
    {
        return "Ini adalah suara Reptil";
    }
}

class Singa : Mamalia
{
    public Singa(string nama, int umur) : base(nama, umur, 4)
    {
    }

    public override string Suara()
    {
        return "Rawr";
    }

    public void Mengaum()
    {
        Console.WriteLine($"{Nama} Mengaum");
    }
}

class Gajah : Mamalia
{
    public Gajah(string nama, int umur) : base(nama, umur, 4)
    {
    }

    public override string Suara()
    {
        return "Suara Gajah";
    }
}

class Ular : Reptil
{
    public Ular(string nama, int umur, double panjangTubuh) : base(nama, umur, panjangTubuh)
    {
    }

    public override string Suara()
    {
        return "Ssssss";
    }

    public void Merayap()
    {
        Console.WriteLine($"{Nama} merayap");
    }
}

class Buaya : Reptil
{
    public Buaya(string nama, int umur, double panjangTubuh) : base(nama, umur, panjangTubuh)
    {
    }

    public override string Suara()
    {
        return "Awrrr";
    }
}

class KebunBinatang
{
    private List<Hewan> koleksiHewan = new List<Hewan>();

    public void TambahHewan(Hewan hewan)
    {
        koleksiHewan.Add(hewan);
    }

    public void DaftarHewan()
    {
        Console.WriteLine("Daftar Hewan di Kebun Binatang : ");
        for (int i = 0; i < koleksiHewan.Count; i++)
        {
            Console.WriteLine(koleksiHewan[i].InfoHewan());
        }
    }

    public List<Hewan> GetHewanList()
    {
        return koleksiHewan;
    }
}

class Program
{
    public static void Main(string[] args)
    {
        KebunBinatang kebunBinatang = new KebunBinatang();

        Singa singa = new Singa("Sing", 5);
        Gajah gajah = new Gajah("Dumbo", 10);
        Ular ular = new Ular("Python", 3, 2.5);
        Buaya buaya = new Buaya("Croco", 8, 4.0);

        kebunBinatang.TambahHewan(singa);
        kebunBinatang.TambahHewan(gajah);
        kebunBinatang.TambahHewan(ular);
        kebunBinatang.TambahHewan(buaya);

        kebunBinatang.DaftarHewan();

        Console.WriteLine("\nSuara Hewan :");
        List<Hewan> hewanList = kebunBinatang.GetHewanList();
        for (int i = 0; i < hewanList.Count; i++)
        {
            Console.WriteLine($"{hewanList[i].Nama}: {hewanList[i].Suara()}");
        }

        singa.Mengaum();
        ular.Merayap();

    }
}
