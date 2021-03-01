using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
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
        public static string CarDescriptionTooShort = "Araba tanımı çok kısa.";
        public static string ImageLimitExceded = "Resim Sınırı Aşıldı. Her araç maximum 5 resme sahip olabilir.";
        public static string ImageHasBeenAddedSuccessfully = "Resim başarı ile eklend!";
        public static string UserRegistered = "Kullanıcı Kaydedildi.";
        public static string UserNotFound = "Kullanıcı Bulunamadı.";
        public static string PasswordError = "Sifre Hatalı";
        public static string SuccessfulLogin = "Giriş Başarılı";
        public static string UserAlreadyExists = "Kullanıcı Zaten Var";
        public static string AccessTokenCreated = "Token Oluşturuldu.";
        public static string AuthorizationDenied = "Yetki reddedildi.";
    }
}
