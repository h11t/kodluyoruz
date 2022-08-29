
Focus focus=new Focus();
Console.WriteLine("*************İNTERFACE***********");
Console.WriteLine(focus.HangiMarkaninAraci().ToString());
Console.WriteLine(focus.KacTekerlektenOlusur());
Console.WriteLine(focus.StandartRengiNe().ToString());

Console.WriteLine("***************");
Civic civic=new Civic();
Console.WriteLine(civic.HangiMarkaninAraci().ToString());
Console.WriteLine(civic.KacTekerlektenOlusur());
Console.WriteLine(civic.StandartRengiNe().ToString());

NewFocus newFocus=new NewFocus();
Console.WriteLine("***************ABSTRACT*************");
Console.WriteLine(newFocus.HangiMarkaninAraci().ToString());
Console.WriteLine(newFocus.KacTekerlektenOlusur());
Console.WriteLine(newFocus.StandartRengiNe().ToString());

NewCivic newcivic=new NewCivic();
Console.WriteLine("***********************");
Console.WriteLine(newcivic.HangiMarkaninAraci().ToString());
Console.WriteLine(newcivic.KacTekerlektenOlusur());
Console.WriteLine(newcivic.StandartRengiNe().ToString());