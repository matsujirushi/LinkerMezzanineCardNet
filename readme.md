# Summary

LinkerMezzanineCardNet is .NET class library for [Linker Mezzanine card](http://www.96boards.org/product/linker-mezzanine-starter-kit/).

# Environment

- [DragonBoard 410c](http://www.chip1stop.com/dispDetail.do?partId=ARRD-0000033)
- [96BOARDS-STARTER-KIT](http://www.chip1stop.com/dispDetail.do?partId=LINS-0000001) (Linker Mezzanine card and some modules)
- [Windows 10 IoT Core](https://developer.microsoft.com/ja-jp/windows/iot)

# Implementation status

Module|Status
-|-
Button Module|Finish
5mm Red LED Module|Finish
LDR Module|
Thermal Module|
Linear/Slide Potentiometer Module|Coding
Tilt Module|Finish
Touch Sensor Module|Finish
Relay Module|Finish

# Sample Code

## Module

### Linker Button

```csharp
var module = new LinkerButton(LinkerMezzanineCard.GetConnectorD2());
for (;;)
{
    Debug.WriteLine(module.Button);
    await Task.Delay(200);
}
```

### Linker LED

```csharp
var module = new LinkerLED(LinkerMezzanineCard.GetConnectorD1());
for (;;)
{
    module.Led = true;
    await Task.Delay(100);
    module.Led = false;
    await Task.Delay(400);
}
```

### Linker Tilt

```csharp
var module = new LinkerTilt(LinkerMezzanineCard.GetConnectorD2());
for (;;)
{
    Debug.WriteLine(module.Tilt);
    await Task.Delay(200);
}
```

### Linker Touch Sensor

```csharp
var module = new LinkerTouchSensor(LinkerMezzanineCard.GetConnectorD2());
for (;;)
{
    Debug.WriteLine(module.Touch);
    await Task.Delay(200);
}
```

### Linker Relay

```csharp
var module = new LinkerRelay(LinkerMezzanineCard.GetConnectorD1());
for (;;)
{
    module.Relay = true;
    await Task.Delay(1000);
    module.Relay = false;
    await Task.Delay(4000);
}
```

## Basic

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
