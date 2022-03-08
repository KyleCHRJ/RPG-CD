using PCR.SRC.Entities;

{
    Hero Knight = new Knight("\nName: Karen\nLevel:", 1, "\nClass: Knight", "\nHP: 600", "\nMagic Power: 100", "\n\nAbilitys:\n\nSword Attack", "\nJudgment Sword Attack", "\nDivine Justice");

    Console.Write(Knight);
    Console.Write(Knight.Attack());
    Console.Write(Knight.Attack(100));
    Console.Write(Knight.Attack(200));

    Hero Ninja = new Ninja("\nName: Kusho\nLevel:", 1, "\nClass: Ninja", "\nHP: 150", "\nMagic Power: 200", "\n\nAbilitys:\n\nBlade Attack", "\nShuriken", "\nAssassins Mark");

    Console.Write(Ninja);
    Console.Write(Ninja.Attack());
    Console.Write(Ninja.Attack(100));
    Console.Write(Ninja.Attack(200));


    Hero WhiteWitch = new WhiteWitch("\nName: Luna\nLevel:", 1, "\nClass: White Witch", "\nHP: 200", "\nMagic Power: 500", "\n\nAbilitys:\n\nIllumination Attack", "\nLight Power", "\nMoon Light");

    Console.Write(WhiteWitch);
    Console.Write(WhiteWitch.Attack());
    Console.Write(WhiteWitch.Attack(100));
    Console.Write(WhiteWitch.Attack(200));

    Hero BlackWizard = new BlackWizard("\nName: Ragie V.\nLevel:", 1, "\nClass: Black Wizard", "\nHP: 150", "\nMagic Power: 600", "\n\nAbilitys:\n\nDark Attack", "\nEvil Power", "\nDark Matter");

    Console.Write(BlackWizard);
    Console.Write(BlackWizard.Attack());
    Console.Write(BlackWizard.Attack(100));
    Console.Write(BlackWizard.Attack(200));




}
