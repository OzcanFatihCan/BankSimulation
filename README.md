# BankSimulation

Merhaba,

### 1. Uygulama mimariye uygun şekilde geliştirilmeye çalışılmıştır. Sql komutları, varlıklar, hata kontrolleri oluşturulmuştur.


### 2. SQL ile ilgili kullandıklarım;

* Transaction, yaşanabilecek hatalara karşın banka işleminin iptal edilmesi için kullanıldı
* Trigger, oluşturulan müşteri hesap numarasından tetiklenerek müşteriye bakiyesini tutabileceği, borçlarını takip edebileceği iki farklı tabloda alan oluşturuldu.
* CRUD, klasik ekleme, silme, güncelleme işlemi kullanılmıştır. Silme metoduna yer verilmedi.
* Procedure, DataAccessLayerda servis ile ilgili uzun kodları parametreli procedür haline getirmek için kullanıldı.

### 3.Uygulamanın çalışabilmesi için, 

##### MSSQL'e dosyalar arasında bulunan DB yedeği dahil edilmelidir. DB yedeği backup ile oluşturulmuştur. Database sağ tık Restore Database seçeneği ile açılan sayfada device kısmından indirilen backupı MSSQL'e dahil edebilirsiniz. Veri tabanınızı ayarlamayı unutmayınız.



### 4. Uygulama arayüzünden görseller

##  Giriş Ekranı

https://github.com/OzcanFatihCan/BankSimulation/assets/93872480/ee84ca3d-37f2-4b0b-9c2c-039d4b204b73

##  Arayüz

https://github.com/OzcanFatihCan/BankSimulation/assets/93872480/9f5720c2-977a-445b-baf6-f225d865fa04

##  Hata kontrolleri ve diğerleri

![image](https://github.com/OzcanFatihCan/BankSimulation/assets/93872480/6218c46c-65ff-4e09-bf72-f1e6a9cde7e0)
![image](https://github.com/OzcanFatihCan/BankSimulation/assets/93872480/d00f24e6-e635-448c-b597-4bd2491ca277)
![image](https://github.com/OzcanFatihCan/BankSimulation/assets/93872480/5f913e30-d072-4175-9cf5-ec18f9399b21)
![image](https://github.com/OzcanFatihCan/BankSimulation/assets/93872480/d0b0229b-b69c-4235-ac3f-03e6ba406050)
![image](https://github.com/OzcanFatihCan/BankSimulation/assets/93872480/c3ed2063-9879-42bc-9a7b-f56fd5b80ac0)
![image](https://github.com/OzcanFatihCan/BankSimulation/assets/93872480/8665c43f-501d-4361-a8b0-6fa0a5294304)
![image](https://github.com/OzcanFatihCan/BankSimulation/assets/93872480/51aba139-a5ab-4bce-963e-921f4df8a25f)
![image](https://github.com/OzcanFatihCan/BankSimulation/assets/93872480/ccca61cc-9976-4be6-844e-b0dd8a22b44d)
![image](https://github.com/OzcanFatihCan/BankSimulation/assets/93872480/ccbe5a76-c6da-4a9d-8aad-c9a3528597ae)
![image](https://github.com/OzcanFatihCan/BankSimulation/assets/93872480/c40cb477-aa53-4062-bd58-962a0fb3a41e)
![image](https://github.com/OzcanFatihCan/BankSimulation/assets/93872480/1a3b2076-422d-4520-84a7-f7687752a47e)
![image](https://github.com/OzcanFatihCan/BankSimulation/assets/93872480/6179f189-9cb9-4590-a5eb-a3f3c72517d8)
![image](https://github.com/OzcanFatihCan/BankSimulation/assets/93872480/aceb4eb4-f495-4d7b-b6d4-f3f66c416aee)
![image](https://github.com/OzcanFatihCan/BankSimulation/assets/93872480/330e403b-3506-4ac2-92b4-2586f5386e2e)
![image](https://github.com/OzcanFatihCan/BankSimulation/assets/93872480/04b6b654-5121-44b7-ae60-8f498c7487f5)
![image](https://github.com/OzcanFatihCan/BankSimulation/assets/93872480/6eb937a8-55a7-479d-a209-24608dc6e5e8)

##  Procedures

![image](https://github.com/OzcanFatihCan/BankSimulation/assets/93872480/4413b457-0f50-46ee-837c-5c5a3b1a0252)
![image](https://github.com/OzcanFatihCan/BankSimulation/assets/93872480/68e91a2e-2e21-4277-83ae-d1296c3bea98)
![image](https://github.com/OzcanFatihCan/BankSimulation/assets/93872480/0979fa81-29db-4d51-9805-2eef7b727f25)
Diğer prosedür görselleri için db içerisini kontrol edebilirsiniz.

#### Projenin kurulumu esnasında sorun yaşarsanız, mail adresimden bana ulaşabilirsiniz.










