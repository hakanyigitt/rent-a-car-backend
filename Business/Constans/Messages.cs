using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constans
{
    public static class Messages
    {
        //System
        public static string MaintenanceTime = "Sistem bakımada";

        //Car
        public static string CarAdded = "Araba eklendi";
        public static string CarNameInvalid = "Araba ismi geçersiz";       
        public static string CarsListed = "Arabalar listelendi";
        public static string CarUpdated = "Araba bilgileri güncellendi";
        public static string CarDeleted = "Araba listeden silindi";
        public static string CarDetailListed = "Araba detayları listelendi";
        public static string CarNameAlreadyExists = "Bu isimde zaten başka bir araba var";

        //Color
        public static string ColorDeleted = "Katologdan renk silindi";
        public static string ColorAdded = "Katologa renk eklendi";
        public static string ColorUpdated = "Renk bilgileri güncellendi";
        public static string ColorsListed = "Renkler listelendi";

        //Brand
        public static string BrandsListed = "Markalar listelendi";
        public static string BrandAdded = "Marka eklendi";
        public static string BrandUpdated = "Marka bilgileri güncellendi";
        public static string BrandDeleted = "Marka silindi";

        //Customer
        public static string CustomerListed = "Müşteriler listelendi";
        public static string CustomerAdded = "Müşteri eklendi";
        public static string CustomerUpdated = "Müşteri bilgileri güncellendi";

        //Rental
        public static string RentalInsertSuccess = "Kiralama işlemi başarılı";
        public static string RentalInsertError = "Araba teslim edilmediği için kiralama yapılamamıştır.";
        public static string RentalsListed = "Kiralama bilgileri listelenmiştir";
        public static string RentalsDeleted = "Kiralama işlemi iptal edilmiştir";
        public static string RentalsUpdate = "Kiralama işlemi güncellenmiştir";

        //CarImage
        public static string CarImageDeleted = "Araba resmi silindi";
        public static string CarImageAdded = "Araba resmi eklendi";
        public static string CarImageUpdated = "Araba resmi güncellendi";

        //Auth
        public static string AccessTokenCreated = "Token oluşturuldu";
        public static string UserAlreadyExists = "Kullanıcı mevcut";
        public static string UserRegistered = "Kayıt oldu";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Parola hatası";
        public static string SuccessfulLogin = "Başarılı giriş";
        public static string AuthorizationDenied = "Yetkiniz yok";
        
    }
}
