# Summary

LinkerMezzanineCardNet is .NET class library for [Linker Mezzanine card](http://www.96boards.org/product/linker-mezzanine-starter-kit/).

# Environment

- [DragonBoard 410c](http://www.chip1stop.com/dispDetail.do?partId=ARRD-0000033)
- [96BOARDS-STARTER-KIT](http://www.chip1stop.com/dispDetail.do?partId=LINS-0000001) (Linker Mezzanine card and some modules)
- [Windows 10 IoT Core](https://developer.microsoft.com/ja-jp/windows/iot)

# Implementation status

Module|Status
-|-
Button Module|
5mm Red LED Module|Coding
LDR Module|
Thermal Module|
Linear/Slide Potentiometer Module|Coding
Tilt Module|
Touch Sensor Module|
Relay Module|

# Sample Code

## ADC

```csharp
var adc = await LinkerMezzanineCard.GetAdcDevice();
var value = adc.Read(0);
Debug.WriteLine(value.ToString("f3"));
```

## DIO

```csharp
var led = LinkerMezzanineCard.GetConnectorD1();
led[0].SetDriveMode(GpioPinDriveMode.Output);
for(;;)
{
    led[0].Write(GpioPinValue.High);
    await Task.Delay(100);
    led[0].Write(GpioPinValue.Low);
    await Task.Delay(400);
}
```
