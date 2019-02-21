<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestClient.aspx.cs" Inherits="SayHelloClient.TestClient" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="../Scripts/jquery-3.3.1.js" type="text/javascript"></script>
</head>
<body>
    <form id="form1" runat="server">

        <div><br />Example A</div>
        <div id="searchresultsA"></div>
        <div><br />Example B</div>
        <div id="searchresultsB"></div>
        <div><br />Example C</div>
        <div id="searchresultsC"></div>
        <div><br />Example D</div>
        <div id="searchresultsD"></div>
        

        <script type="text/javascript">
            // alert("Hello from Roberto"); 
            $(document).ready(function () {
                $.ajax({
                    type: "POST",
                    url: "http://localhost:52790/SayHelloWS.asmx/SayHelloString",
                    data: "firstName=Roberto&lastName=Panetta",
                    dataType: "text",
                    success: function (data) {
                        $("#searchresultsA").html(data);
                    }
                });

                // For jason
                 $.ajax({
                    type: "POST",
                    url: "http://localhost:52790/SayHelloWS.asmx/SayHelloJson",
                     data: "{firstName:'Roberto' , lastName:'Panetta'}",
                     contentType: "application/json; charset=utf-8" ,
                    dataType: "json",
                    success: function (data) {
                        $("#searchresultsB").html(data.d);
                    }
                });

                //For Object
                 $.ajax({
                    type: "POST",
                    url: "http://localhost:52790/SayHelloWS.asmx/SayHelloObject",
                     data: "{firstName:'Roberto' , lastName:'Panetta'}",   
                     contentType: "application/json; charset=utf-8" ,
                    dataType: "json",
                     success: function (data) {
                         var SayHelloObject = data.d;
                        $("#searchresultsC").html(SayHelloObject.Greeting+ ' '+ SayHelloObject.Name);
                    }
                });

                //For List
                 $.ajax({
                    type: "POST",
                    url: "http://localhost:52790/SayHelloWS.asmx/SayAllHelloObjects",
                     data: "{firstName:'Roberto' , lastName:'Panetta'}",
                     contentType: "application/json; charset=utf-8" ,
                     dataType: "json",                     
                     success: function (data) {                        
                         var SayAllHelloObjects = data.d;
                         SayAllHelloObjects.forEach(function (element) {
                             $("#searchresultsD").append("<p>" + element.Greeting + ' ' + element.Name + "</p>");
                         });
               
                        
                    }
                });
            });
        </script>
    </form>
</body>
</html>
