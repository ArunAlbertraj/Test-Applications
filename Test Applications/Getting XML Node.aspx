<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Getting XML Node.aspx.cs" Inherits="Test_Applications.Getting_XML_Node" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>    
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.0/jquery.min.js"></script>
    <script src="https://code.jquery.com/ui/1.12.1/jquery-ui.js"></script>
    <script>
        $(document).ready(function () {
            $('#test').dialog({
                //autoOpen: false,
                width: "50%",
                modal:true,
                title: "Add New Reference"
            });

            $(".add").click(function () {
                debugger;
                //$("form > p:first-child").clone(true).insertBefore("form > p:last-child");      
               
                $("#test").dialog('open');
            });
        $(".remove").click(function () {
            debugger;
            $(this).parent().remove();
        });

        //   $('#fire').click(function (event) {
        //    debugger;
        //    event.preventDefault();
        //    var newForm = jQuery('<form>', {
        //        'action': 'http://www.google.com/search',
        //        'target': '_top'
        //    }).append(jQuery('<input>', {
        //        'name': 'q',
        //        'value': 'stack overflow',
        //        'type': 'hidden'
        //    }));
        //    newForm.submit();
        //});
        //$(document).click(function () {
        //    $('<form action="form2.html"></form>').appendTo('body').submit();
        //});
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
    <a id="fire" href="#" title="submit form">Submit form</a>
    </div>
    </form>
   <%-- <form>
    <p>
        <label>Name:</label> <input id="" type="text">
        <label>Age:</label> <input id="" type="text">
        <span class="remove">Remove</span>
    </p>
    <p>
        <button class="add">Add fields</button>
    </p>
        <div id="test"  title="Contact form">
   <p>appear now</p>
 </div>
</form>--%>
</body>
</html>
