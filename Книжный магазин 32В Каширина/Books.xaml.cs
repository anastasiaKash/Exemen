using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Книжный_магазин_32В_Каширина
{
    /// <summary>
    /// Логика взаимодействия для Books.xaml
    /// </summary>
    public partial class Books : Page
    {
        List<Книги> BooksList = Base.tE.Книги.ToList();
     
        public Books()
        {
            InitializeComponent();
           
            DBBooks.ItemsSource = BooksList;


        }
        int i = -1;
        private void MadiaElement_Intialized(object sender, EventArgs e)
        {
            i++;
            if (i < BooksList.Count)
            {
                MadiaElement ME = (MadiaElement)sender;
                Книги B =  BooksList[i];
                Uri U = new Uri(B.Обложка ,UriKind.RelativeOrAbsolute);
                  MadiaElement.        
                    }

            }

    }
}
    

