using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
      
        public static string CarAdded = "Araba Eklendi";
        public static string CarUpdated = "Araba Güncellendi";
        public static string CarDeleted = "Araba Silindi";
        public static string CarNameInvalid = "Araba ismi geçersiz.";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string CarsListed = "Arabalar listelendi";
        public static string BrandAdded = "Marka Eklendi";
        public static string BrandNameInvalid = "Marka ismi geçersiz.";
        public static string ColourAdded = "Renk Eklendi";
        public static string ColourNameInvalid = "Renk ismi geçersiz.";
        public static string RentalAdded = "Araba kiralandı.";
        public static string RentalNotAdded = "Araba kiralanamadı.";
        public static string CarImageUploaded = "Araç resmi yüklendi.";
        public static string CarImageDeleted="Araç resmi silindi.";
        public static string CarImageUpdated = "Araç resmi güncellendi.";
        public static string ExceedImageLimited="Resim sayısı aşıldı.";
        public static string UserNotFound="Kullanıcı mevcut";
        public static string PasswordError="Parola hatalı";
        public static string SuccessfulLogin="Giriş başarılı";
        public static string UserAlreadyExists = "UserAlreadyExists";
        public static string AccessTokenCreated = "Access Token oluşturuldu";
        public static string UserRegistered="Kayıt olusturuldu";
        public static string AuthorizationDenied;
        public static string SuccessMessage = "işlem başarılı";
      
    }
}
