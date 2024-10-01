using D4P2;

Tesla tesla = new Tesla("S3", "White", 50);
Console.WriteLine(tesla.Start());
Console.WriteLine(tesla.Stop());

Seat seat = new Seat("SeatModel", "Black");
Console.WriteLine(seat.Start());
Console.WriteLine(seat.Stop());