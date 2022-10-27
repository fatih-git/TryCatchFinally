using System;

namespace TryCatchFinally
{

    class Program
    {

        static void Main(string[] args)
        {

            try     //Try içine hataya sebep olabilecek kod yazılır
            {
                //Hataya sebep olabilcek kod
                Console.WriteLine("Bir sayı giriniz");
                int sayi = Convert.ToInt32(Console.ReadLine());   //Kullanıcı harf de girebilir.
                Console.WriteLine("Girmiş olduğunuz sayı= " + sayi);
            }
            catch(Exception ex)     //Catch kodda hata olduğunda hatayı yakalar ve catchin yanındaki parantezde bu hataya isim vermiş oluruz.
            {
                Console.WriteLine("Hata: " + ex.Message.ToString());
            }
            finally     //Yazılan kod hata yakalasa da yakalamasa da finally kısmındaki kod yapılır.
            {
                Console.WriteLine("İşlem Tamamlandı");
            }
            //Finally kullanılmak zorunda değildir.

            /*
             Yani try-catch-fianlly kodda hata olması durumunda
            uygulamanın çalışmasını durdurmak yarine bizi yapmamızı 
            istediğimiz şeyi yapar. Bu sayede ölümcül işlerde çalışan
            programlar, asla kapatılamması gereken uygulamalar, 
            devamlı çalışması gereken kodlar küçük bir hata yüzünden 
            durmamış olur bize hatanın ne olduğunu bildirip durmadan
            çalışmaya devam eder.

            Tabi bu compiler hatalarında değil algoritmik hatalarda geçerli 
            olacaktır.
             */

            try
            {
                //int a = int.Parse(null);
                //int a = int.Parse("ede");
                int a = int.Parse("-20000000000");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Boş değer");
                Console.WriteLine(ex);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Veri tipi uygunsuz");
                Console.WriteLine(ex);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("integer bu kadar büyük/küçük bir değeri kabul edemez!");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("İşlem Başarıyla Tamamlandı!");
            }

        }

    }

}