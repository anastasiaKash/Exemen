//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Книжный_магазин_32В_Каширина
{
    using System;
    using System.Collections.Generic;
    
    public partial class Книги
    {
        public int id_книги { get; set; }
        public string Название { get; set; }
        public int Автор { get; set; }
        public int Цена { get; set; }
        public int Количество_магазин { get; set; }
        public int Количество_склад { get; set; }
        public string Обложка { get; set; }
    
        public virtual Авторы Авторы { get; set; }
    }
}
