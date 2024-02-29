Address myaddress1 = new Address("Graaf Karel de Goedelaan", 11, 8500, "kortrijk", "Belgium");
Address myaddress2 = new Address("Graaf Karel de Goedelaan", 9, 8500, "kortrijk", "Belgium");

Person myperson = new Person("Roan", "Vandemeulebroucke", 19, [myaddress1, myaddress2], ["Roanvdmb@gmail.com", "Rooan.vandemeulebroucke@student.howest.be"], ["+32 000 00 00 00", "+32 999 99 99 99"]);
Console.WriteLine(myperson);