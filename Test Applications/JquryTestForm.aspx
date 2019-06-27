<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="JquryTestForm.aspx.cs" Inherits="Test_Applications.JquryTestForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>show dynamic dialog box in jquery</title>
<link href="http://ajax.googleapis.com/ajax/libs/jqueryui/1.8/themes/base/jquery-ui.css" rel="stylesheet" type="text/css"/>
  <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.5/jquery.min.js"></script>
  <script src="http://ajax.googleapis.com/ajax/libs/jqueryui/1.8/jquery-ui.min.js"></script>
    <script src="https://code.jquery.com/jquery-1.11.1.min.js"></script> 
<script src="https://code.jquery.com/ui/1.11.1/jquery-ui.min.js"></script>
<link rel="stylesheet" href="https://code.jquery.com/ui/1.11.1/themes/smoothness/jquery-ui.css" />
      <script type="text/javascript">
        $(function() {
            $("input:button").click(function() {
                var NewDialog ="<div class=\"PopupMessage\" title=\"Save item\"> </div>";
                var _id = $(this).attr('id');
                if (_id == "Button1") {
                    debugger;
          //          NewDialog = $('<div class="popup" title="Save item">\
                    //Item has been saved successfully!</div>');
                    var Elements = "<li><a href='#' onclick=XmlElements() id='btn_loadEditor' title='Editor'>Arun Albert</a></li>";
                    $("#NewDialog").append(Elements);
                }
                else if (_id == "Button2") {
                    NewDialog = $('<div class="popup" title="Update item">\
          Item has been updated successfully!</div>');
                }
                else if (_id == "Button3") {
                    NewDialog = $('<div class="popup" title="Delete item">\
          Item has been deleted successfully!</div>');
                }
                
                $("#NewDialog").dialog({
                        autoOpen: false
                });

                NewDialog.dialog({
                    resizable: true,
                    modal: true,
                    show: 'clip',
                    buttons: {
                        "Ok": function() {
                            $(this).dialog("close");
                        }
                    }
                });
            });
        });
</script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <center>
<div style="width:400px;height:400px"> 
<input id="Button1" type="button" value="Save" />
<input id="Button2" type="button" value="Update" />
<input id="Button3" type="button" value="Delete" /></div></center>
    </div>
    </form>
</body>
</html>
