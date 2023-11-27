using System.Collections.Generic;

namespace Background
{
    //internal class Category
    //{
    //    public int Id { get => id; set => id = value; }
    //    internal List<Category> Zywnosc { get => categoryList; set => categoryList = value; }
    //    internal List<Category> Mieszkanie { get => categoryList; set => categoryList = value; }
    //    internal List<Category> Transport { get => categoryList; set => categoryList = value; }
    //    internal List<Category> OpiekaZdrowotna { get => categoryList; set => categoryList = value; }
    //    internal List<Category> Edukacja { get => categoryList; set => categoryList = value; }
    //    internal List<Category> Rozrywka { get => categoryList; set => categoryList = value; }
    //    internal List<Category> OdziezIDom { get => categoryList; set => categoryList = value; }
    //    internal List<Category> Inne { get => categoryList; set => categoryList = value; }

    //    Category(string name)
    //    {
    //        this.name = name;
    //        this.id = Id + 1;
    //    }
    //    private void InitCategories()
    //    {
    //        Zywnosc = new List<Category>
    //        {
    //            new Category("Żakupy spożywcze"),
    //            new Category("Posiłki poza domem")
    //        };

    //        Mieszkanie = new List<Category>
    //        {
    //            new Category("Wynajem/miesięczna rata kredytu hipotecznego"),
    //            new Category("Opłaty za media (prąd, gaz, woda, internet"),
    //            new Category("Ubezpieczenie mieszkania")
    //        };

    //        Transport = new List<Category>
    //        {
    //            new Category("Paliwo"),
    //            new Category("Opłaty za parking"),
    //            new Category("Ubezpieczenie samochodu"),
    //            new Category("Przeglądy techniczne i naprawy")
    //        };

    //        OpiekaZdrowotna = new List<Category>
    //        {
    //            new Category("Składki na ubezpieczenie zdrowotne"),
    //            new Category("Wizyty u lekarza"),
    //            new Category("Leki i suplementy")
    //        };

    //        Edukacja = new List<Category>
    //        {
    //            new Category("Opłaty za szkołę"),
    //            new Category("Kursy lub szkolenia dodatkowe"),
    //            new Category("Materiały edukacyjne")
    //        };

    //        Rozrywka = new List<Category>
    //        {
    //            new Category("Filmy, koncerty, wydarzenia kulturalne"),
    //            new Category("Subskrypcje usług streamingowych"),
    //            new Category("Wyjścia")
    //        };

    //        OdziezIDom = new List<Category>
    //        {
    //            new Category("Zakupy odzieży"),
    //            new Category("Meble i dekoracje"),
    //            new Category("Sprzęt AGD i RTV")
    //        };

    //        Inne = new List<Category>
    //        {
    //            new Category("Wydatki związane z zwierzętami domowymi"),
    //            new Category("Nieprzewidziane wydatki")
    //        };

    //        Categories.CategoriesList.AddRange(Zywnosc);
    //        Categories.CategoriesList.AddRange(Mieszkanie);
    //        Categories.CategoriesList.AddRange(Transport);
    //        Categories.CategoriesList.AddRange(OpiekaZdrowotna);
    //        Categories.CategoriesList.AddRange(Edukacja);
    //        Categories.CategoriesList.AddRange(Rozrywka);
    //        Categories.CategoriesList.AddRange(OdziezIDom);
    //        Categories.CategoriesList.AddRange(Inne);
    //    }

    //    private List<Category> categoryList;

    //    private int id;
    //    private string name;
    //}

    internal class Category
    {
        private static int globalId = 0;
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Category> Zywnosc { get; set; }
        public List<Category> Mieszkanie { get; set; }
        public List<Category> Transport { get; set; }
        public List<Category> OpiekaZdrowotna { get; set; }
        public List<Category> Edukacja { get; set; }
        public List<Category> Rozrywka { get; set; }
        public List<Category> OdziezIDom { get; set; }
        public List<Category> Inne { get; set; }

        public Category(string name)
        {
            Id = ++globalId;
            Name = name;       
        }

        public static Category InitializeCategories()
        {
            Category categories = new Category("Categories");

            categories.Zywnosc = new List<Category>
            {
                new Category("Żakupy spożywcze"),
                new Category("Posiłki poza domem")
            };

            categories.Mieszkanie = new List<Category>
            {
                new Category("Wynajem/miesięczna rata kredytu hipotecznego"),
                new Category("Opłaty za media (prąd, gaz, woda, internet)"),
                new Category("Ubezpieczenie mieszkania")
            };

            categories.Transport = new List<Category>
            {
                new Category("Paliwo"),
                new Category("Opłaty za parking"),
                new Category("Ubezpieczenie samochodu"),
                new Category("Przeglądy techniczne i naprawy")
            };

            categories.OpiekaZdrowotna = new List<Category>
            {
                new Category("Składki na ubezpieczenie zdrowotne"),
                new Category("Wizyty u lekarza"),
                new Category("Leki i suplementy")
            };

            categories.Edukacja = new List<Category>
            {
                new Category("Opłaty za szkołę"),
                new Category("Kursy lub szkolenia dodatkowe"),
                new Category("Materiały edukacyjne")
            };

            categories.Rozrywka = new List<Category>
            {
                new Category("Filmy, koncerty, wydarzenia kulturalne"),
                new Category("Subskrypcje usług streamingowych"),
                new Category("Wyjścia")
            };

            categories.OdziezIDom = new List<Category>
            {
                new Category("Zakupy odzieży"),
                new Category("Meble i dekoracje"),
                new Category("Sprzęt AGD i RTV")
            };

            categories.Inne = new List<Category>
            {
                new Category("Wydatki związane z zwierzętami domowymi"),
                new Category("Nieprzewidziane wydatki")
            };

            return categories;
        }
    }
}