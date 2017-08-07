<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="APIClient.aspx.cs" Inherits="themiamiagency.API.APIClient" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>The Miami Agency Quotes</title>
</head>
<body>
    <form id="form1" runat="server">
    <div id="quotes">
    
    </div>
    </form>
    <script src="Scripts/bootstrap.min.js"></script>
    <script>
        $(function () {
            $.getJSON('api/AutoQuote').done(function (data) {
                $.each(data, function (index, AutoQuote) {
                    for (prop in AutoQuote) {
                        $('#quotes').append(prop + ':' + AutoQuote[prop] + '<br />');
                    }
                    $('#quotes').append('<br />');
                });
                });
        });
    </script>
</body>
</html>
