﻿namespace PharmancyPurchase.Data.Migrations
{
    using System;
    using System.Linq;
    using Core.Domain.Entities;

    public static class Seed
    {
        public static void Configuration(this AppDbContext context)
        {
            if (!context.Medicaments.Any())
            {
                var medicament1 = new Medicament
                {
                    Title = "Анаферон таблетки №20",
                    Description = MedicamentAnapheronDesc,
                    ItemsAvailable = 100,
                    Price = 64.9,
                    Vendor = ""
                };
                var medicament2 = new Medicament
                {
                    Title = "Вітаміни шипучі Swiss Energy Immunostim №20",
                    Description = MedicamentVitaminsDesc,
                    ItemsAvailable = 100,
                    Price = 105.9,
                    Vendor = "Kendy (Болгария)"
                };
                var medicament3 = new Medicament
                {
                    Title = "Тантум верде спрей 45 мг 30 мл №1",
                    Description = MedicamentVitaminsDesc,
                    ItemsAvailable = 100,
                    Price = 134.9,
                    Vendor = "Angelini Francesco (Италия)"
                };
                
                context.Add(medicament1);
                context.Add(medicament2);
                context.Add(medicament3);

                var sale1 = new Sale
                {
                    //Title = "Sale №1",
                    DateTime = DateTime.Now,
                    TotalPrice = medicament1.Price + medicament2.Price
                };
                sale1.MedicamentSales.Add(new MedicamentSale {Count = 1, Medicament = medicament1, Sale = sale1});
                sale1.MedicamentSales.Add(new MedicamentSale {Count = 1, Medicament = medicament2, Sale = sale1});

                var sale2 = new Sale
                {
                    //Title = "Sale №2",
                    DateTime = DateTime.Now.AddHours(2),
                    TotalPrice = medicament3.Price * 2
                };
                sale1.MedicamentSales.Add(new MedicamentSale {Count = 2, Medicament = medicament3, Sale = sale2});

                context.Add(sale1);
                context.Add(sale2);
                
                context.SaveChanges();
            }
        }

        private static string MedicamentAnapheronDesc => @"
АНАФЕРОН (ANAFERON) ІНСТРУКЦІЯ ПО ЗАСТОСУВАННЮ
СКЛАД
діюча речовина: 1 таблетка містить антитіла до гамма інтерферону людини афінно очищені: суміш гомеопатичних розведень С12, СЗ0 та С200 – 3 мг;

допоміжні речовини: лактози моногідрат, целюлоза мікрокристалічна, магнію стеарат.

ЛІКАРСЬКА ФОРМА
Таблетки.

ОСНОВНІ ФІЗИКО-ХІМІЧНІ ВЛАСТИВОСТІ:
Таблетки плоскоциліндричної форми, з рискою та фаскою, від білого до майже білого кольору. На одному плоскому боці з рискою нанесено напис MATERIA MEDICA, на іншому плоскому боці нанесено напис ANAFERON.

ФАРМАКОТЕРАПЕВТИЧНА ГРУПА
Гомеопатичний препарат.

ФАРМАКОЛОГІЧНІ ВЛАСТИВОСТІ
Препарат застосовується для лікування та профілактики ГРВІ та грипу. При профілактичному та лікувальному застосуванні чинить противірусну дію. Експериментально та клінічно доведена ефективність стосовно вірусів грипу, парагрипу, вірусів простого герпесу 1 та 2 типів (лабіальний герпес, генітальний герпес), інших герпесвірусів (вітряна віспа, інфекційний мононуклеоз), ентеровірусів, вірусу кліщового енцефаліту, ротавірусу, коронавірусу, каліцивірусу, аденовірусу, респіраторно-синцитіального вірусу (РС-вірусу). Препарат знижує концентрацію вірусу в уражених тканинах, діє на систему ендогенних інтерферонів та пов’язаних з ними цитокінів, індукує утворення ендогенних «ранніх» інтерферонів (ІФН α/β) та γ-інтерферону (γ-ІФН).

Має антимутагенні властивості.

ПОКАЗАННЯ
Профілактика та лікування гострих респіраторних вірусних інфекцій (у тому числі грипу).

Комплексна терапія інфекцій, спричинених герпесвірусами (інфекційний мононуклеоз, вітряна віспа, лабіальний герпес, генітальний герпес).

Комплексна терапія і профілактика рецидивів хронічної герпесвірусної інфекції, у тому числі лабіального та генітального герпесу.

Комплексна терапія і профілактика інших гострих та хронічних вірусних інфекцій, спричинених вірусом кліщового енцефаліту, ентеровірусом, ротавірусом, коронавірусом, каліцивірусом.

Комплексна терапія вторинних імунодефіцитних станів різної етіології, у тому числі профілактика та лікування ускладнень вірусних і бактеріальних інфекцій.

ПРОТИПОКАЗАННЯ
Підвищена індивідуальна чутливість до компонентів препарату.

ВЗАЄМОДІЯ З ІНШИМИ ЛІКАРСЬКИМИ ЗАСОБАМИ ТА ІНШІ ВИДИ ВЗАЄМОДІЙ
Випадків несумісності з іншими лікарськими засобами не зареєстровано.

У разі необхідності препарат можна застосовувати сумісно з іншими противірусними, антибактеріальними та симптоматичними засобами.

ОСОБЛИВОСТІ ЗАСТОСУВАННЯ
До складу препарату входить лактози моногідрат, у зв’язку з чим його не рекомендується призначати пацієнтам із природженою галактоземією, синдромом мальабсорбції глюкози або при вродженій лактазній недостатності.

ЗАСТОСУВАННЯ У ПЕРІОД ВАГІТНОСТІ АБО ГОДУВАННЯ ГРУДДЮ
Дані про ефективність та безпеку застосування препарату у період вагітності або годування груддю відсутні, тому його не слід призначати у ці періоди.

ЗДАТНІСТЬ ВПЛИВАТИ НА ШВИДКІСТЬ РЕАКЦІЇ ПРИ КЕРУВАННІ АВТОТРАНСПОРТОМ АБО РОБОТІ З ІНШИМИ МЕХАНІЗМАМИ
Не впливає на швидкість реакції при керуванні автотранспортом або роботі з іншими механізмами.

СПОСІБ ЗАСТОСУВАННЯ ТА ДОЗИ
Препарат приймають внутрішньо по 1 таблетці за 30 хв до або через 30 хв після прийому їжі. Таблетку тримають у роті (бажано не розжовуючи та не ковтаючи) до повного розчинення.

ГРВІ, грип, кишкові інфекції, герпесвірусні інфекції, нейроінфекції.

Лікування потрібно починати як можна раніше при появі перших ознак гострої вірусної інфекції за такою схемою: перші 2 години препарат приймають кожні 30 хв (5 прийомів), потім протягом першої доби – ще 3 таблетки через рівні проміжки часу (усього 8 таблеток протягом першої доби). Починаючи з 2-ї доби й надалі препарат приймають по 1 таблетці 3 рази на добу до повного одужання.

За відсутності покращення на третій день лікування препаратом гострих респіраторних вірусних інфекцій та грипу необхідно звернутися за консультацією до лікаря.

Для профілактики приймають по 1 таблетці 1 раз на добу щоденно протягом 1-3 місяців (протягом усього епідемічного сезону).

Генітальний герпес. При гострих проявах генітального герпесу приймають через рівні проміжки часу за такою схемою: 1-3 день – по 1 таблетці 8 разів на добу, у подальшому – по 1 таблетці 4 рази на добу не менше 3 тижнів.

Для профілактики рецидивів хронічної герпесвірусної інфекції – по 1 таблетці на добу. Рекомендована тривалість профілактичного курсу визначається індивідуально і може досягати 6 місяців.

При застосуванні препарату для лікування та профілактики імунодефіцитних станів – приймають по 1 таблетці на добу.

ДІТИ
Не застосовувати дітям.

ПЕРЕДОЗУВАННЯ
Випадків передозування не зареєстровано. При випадковому передозуванні можливі диспептичні прояви, спричинені компонентами, що входять до складу препарату.

ПОБІЧНІ РЕАКЦІЇ
Можливі алергічні реакції, включаючи свербіж, висип, кропив’янку, гіперемію шкіри та набряк, утруднення ковтання.

ТЕРМІН ПРИДАТНОСТІ
3 роки.

Не застосовувати препарат після закінчення терміну придатності, зазначеного на упаковці.

УМОВИ ЗБЕРІГАННЯ
Зберігати при температурі не вище 25 °С.

Зберігати у недоступному для дітей місці.

УПАКОВКА
По 20 таблеток у блістері з плівки полівінілхлоридної та фольги алюмінієвої.

По 1 блістеру разом з інструкцією для медичного застосування у картонній коробці.

КАТЕГОРІЯ ВІДПУСКУ
Без рецепта.
";

        private static string MedicamentVitaminsDesc => @"
ВІТАМІНИ ШИПУЧІ SWISS ENERGY IMMUNOSTIM
Цей комплекс вітамінів спрямований на профілактику простудних захворювань, вірусних інфекцій та грипу. Ефективний для підвищення імунітету при неускладнених інфекційних захворюваннях, схильності до частих застуд, пом'якшує тяжкість і скорочує тривалість симптомів застуди.

Прополіс є природним антибіотиком. Він гальмує зростання вірусів і бактерій, пригнічує процеси старіння і робить позитивний вплив на центральну нервову систему. Також прополіс використовується при лікуванні шлункових захворювань, знімає інтоксикацію при отруєннях. Прополіс - це потужна цілюща речовина, яка має імуностимулюючу, противірусну, протизапальну і антигрибкові ефекти.

Головною властивістю ехінацеї є зміцнення імунітету.

Ехінацея активно застосовується при неспокої, депресіях і тривожних станах, надає омолоджуючий ефект на шкіру і організм, знижує холестерин і зміцнює стінки кровоносних судин. Крім цього, ехінацея також є антиалергеною, має протизапальну властивість, допомагає від шкірних грибків, виразок і герпесу.";
    }
}