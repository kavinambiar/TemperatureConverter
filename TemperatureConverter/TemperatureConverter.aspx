<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TemperatureConverter.aspx.cs" Inherits="TemperatureConverter" %>

<!DOCTYPE html>
<html>
    <head>
    <title>Temperature Converter</title>
    <link rel="stylesheet" type="text/css" href="TemperatureConverter.css">
	<link href='https://fonts.googleapis.com/css?family=Indie+Flower' rel='stylesheet' type='text/css'>
    </head>
<body>
    <h1> Temperature Converter </h1>
    <form runat = "server">
    
        <div>
        Convert: &nbsp; <input type = "text" ID = "Fahr" runat = "server" /> Fahrenheit to &nbsp;
        <select ID = "Temperature" runat = "server" />
        <br/> <br/>
        <input type = "submit" value = "OK" ID = "ConvertOnServerClick" OnServerClick= "Convert_ServerClick" runat = "server" />
        <br/> <br/>
        <p style = "font-weight: bold" ID = "Result" runat = "server" > </p>
        </div>

    </form>

</body>
</html>