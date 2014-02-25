%SystemRoot%\Microsoft.NET\Framework\v4.0.30319\installutil.exe WindowsServiceDemo.exe
Net Start Service1
sc config Service1 start= auto
