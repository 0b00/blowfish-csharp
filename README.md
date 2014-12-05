blowfish-csharp
===============

# License
```
Copyright (c) 2007 Novell, Inc.
All Rights Reserved.

This program is free software; you can redistribute it and/or
modify it under the terms of version 2 of the GNU General Public License as
published by the Free Software Foundation.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program; if not, contact Novell, Inc.

To contact Novell about this file by physical or electronic mail,
you may find current contact information at www.novell.com 

Author: Russ Young
  Thanks to: Bruce Schneier / Counterpane Labs 
  for the Blowfish encryption algorithm and
  reference implementation. http://www.schneier.com/blowfish.html
```

#Notes

## Note 1
Had this project on the local drive, wanted to host it somewhere safe.
Don't know where I acquired the original source for this.

Have not tested this code before uploading here.
Use it on your own risk.

## Note 2
Note: Only documented usage for strings.

# Documentation
Create a instance of Blowfish object:
```cs
Blowfish blowfish = new Blowfish(Encoding.Unicode.GetBytes("<Key>"));
Blowfish blowfish = new Blowfish("<Key>");
```

Encrypt:
```cs
string encrypted = blowfish.Encipher("<value>");
```

Decrypt:
```cs
string value = blowfish.Decipher("<encrypted>");
```
