using System;
using Proiect3.Data;
using Proiect3.Models;
using System.IO;
using Microsoft.Maui.Controls;
namespace Proiect3;

public partial class App : Application
{
    static EleviDatabase eleviDatabase;
    static MaterieDatabase materieDatabase;
    static ProfesorDatabase profesorDatabase;
    public App()
    {
        InitializeComponent();

        MainPage = new AppShell();
    }

    public static EleviDatabase GetEleviDatabase()
    {
        if (eleviDatabase == null)
        {
            eleviDatabase = new EleviDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Elevi.db3"));
        }
        return eleviDatabase;
    }

    

    public static MaterieDatabase GetMaterieDatabase()
    {
        if (materieDatabase == null)
        {
            materieDatabase = new MaterieDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Materie.db3"));
        }
        return materieDatabase;
    }

    public static ProfesorDatabase GetProfesorDatabase()
    {
        if (profesorDatabase == null)
        {
            profesorDatabase = new ProfesorDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Profesor.db3"));
        }
        return profesorDatabase;
    }



    public static object Data { get; internal set; }
    public static object EleviDatabase { get; internal set; }
    public static object EleviListDatabase { get; internal set; }
    public static object Database { get; internal set; }
    public static object MaterieDatabase { get; internal set; }
}
