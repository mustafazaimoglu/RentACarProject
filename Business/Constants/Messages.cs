using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba eklendi!";
        public static string CarNotAdded = "Araba eklenmedi!";
        public static string CarDeleted = "Araba silindi!";
        public static string CarUpdated = "Araba Güncellendi!";
        public static string CarNameInvalid = "Araba ismi geçersiz.";
        public static string MaintenanceTime = "Sistem şuan bakımda.";
        public static string CarsListed = "Arabalar listelendi!";
        public static string CarRentTimeError = "Araba henüz dönmedi!";
        internal static string CarDescriptionTooShort = "Araba tanımı çok kısa.";
        internal static string ImageLimitExceded = "Resim Sınırı Aşıldı. Her araç maximum 5 resme sahip olabilir.";
        internal static string ImageHasBeenAddedSuccessfully = "Resim başarı ile eklend!";
    }
}
