# Gumec

Gumec Tower Defence oyunlarından esinlenerek yapılmış bir oyundur. Oyun içerisinde kullanılan assetler gamedev.tv tarafından sağlanmıştır.Oyunda giriş sahnesi bulunuyor, eklemek istersek farklı sahnelerde eklenilebilir.
![Gumec_AI](https://user-images.githubusercontent.com/91124447/201183418-7ec8bf11-8911-4326-afdc-80622483f292.png)

Oyun içerisinde düşman arabalarının gidebileceği yollar bulunmaktadır.Oyun içerisinde grid sistemi kullanılarak koordinatlara göre işlem yapılmıştır.Bunu seçme sebebimiz ise belirli olarak yapay zeka entegresinin kolay olacağı düşünülerek yapılmıştır. Düşmana verilecek yolların koordinat şeklinde olması kontrol edilebilirliğini artırmaktadır. Oyunumuzun amacı bitiş noktasına gelmek isteyen düşman arabalarını engellmeye çalışan "target" isimli objeleri koymak, ve öldürülen düşmanlardan para kazanmak. Oyunumuzda "target" koymak sahip olunan altın miktarını azaltırken, öldürülen her düşmandan para kazanılmaktadır. 

![image](https://user-images.githubusercontent.com/91124447/201183297-de38ec86-30fc-4989-a0b3-5a7c4b1cf560.png)
Her öldürülen düşmandan para kazanılırken, her düşmanın bitiş noktasına gelmesiyle sahip olunan para miktarında azalmak olmaktadır. Oyun içerisinde savunma için kullanılan objeler ise kullanılmaya başlanırsa yine para miktarı azalacaktır. Oyunum grid sistemi ile tasarlanmıştır. Oyun içerisinde tıkladığını noktaya savunma yapmak üzere "target" diye isimlendirdiğim objeler konulmaktadır, ve düşman arabaları üzerinden geçememektedir ve kendilerine göre en yakın yolu tekrar hesaplamaya başlayacaklardır.
