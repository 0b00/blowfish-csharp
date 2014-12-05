Note: Only documented usage for strings.

Create a instance of Blowfish object:
	Blowfish blowfish = new Blowfish(Encoding.Unicode.GetBytes("<Key>"));
	Blowfish blowfish = new Blowfish("<Key>");
	
Encrypt:
	string encrypted = blowfish.Encipher("<value>");

Decrypt:
	string value = blowfish.Decipher("<encrypted>");
