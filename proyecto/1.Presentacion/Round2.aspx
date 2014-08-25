<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Round2.aspx.cs" Inherits="_1.Presentacion.Round2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
      <link href="Resources/Style/StyleSheet1.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="round2a">
        <asp:Label ID="lbl1" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:Label ID="lbl2" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:Label ID="lbl3" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:Label ID="lbl4" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:Label ID="lbl5" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:Label ID="lbl6" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:Label ID="lbl7" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:Label ID="lbl8" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Start" OnClick="Button1_Click" />
    </div>


        <div class="round2b">
        <asp:Label ID="lbl9" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:Label ID="lbl10" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:Label ID="lbl11" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:Label ID="lbl12" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:Label ID="lbl13" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:Label ID="lbl14" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:Label ID="lbl15" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:Label ID="lbl16" runat="server" Text="Label"></asp:Label>

        </div>

        <div class="round2wa">
            <asp:Label ID="lblw1" runat="server"></asp:Label>
            <br />
            <asp:Label ID="lblw2" runat="server"></asp:Label>
            <br />
            <asp:Label ID="lblw3" runat="server"></asp:Label>
            <br />
            <asp:Label ID="lblw4" runat="server"></asp:Label>

        </div>

        
        <div class="round2wb">
            <asp:Label ID="lblw5" runat="server"></asp:Label>
            <br />
            <asp:Label ID="lblw6" runat="server"></asp:Label>
            <br />
            <asp:Label ID="lblw7" runat="server"></asp:Label>
            <br />
            <asp:Label ID="lblw8" runat="server"></asp:Label>

        </div>
        <div class="round2l">
            <asp:Label ID="Label2" runat="server" Text="Losers"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lbll1" runat="server"></asp:Label>
            <br />
            <asp:Label ID="lbll2" runat="server"></asp:Label>
            <br />
            <asp:Label ID="lbll3" runat="server"></asp:Label>
            <br />
            <asp:Label ID="lbll4" runat="server"></asp:Label>

        </div>

         <div class="round2l2">
             <asp:Label ID="lbll5" runat="server"></asp:Label>
             <br />
            <asp:Label ID="lbll6" runat="server"></asp:Label>
            <br />
            <asp:Label ID="lbll7" runat="server"></asp:Label>
            <br />
            <asp:Label ID="lbll8" runat="server"></asp:Label>

        </div>
        
        <p>

            
            </p>
        <div class="winners" >
        <asp:Label ID="Label1" runat="server" Text="Winners"></asp:Label>
        </div>
        <div class="summary">
        <asp:Button ID="btnNext" runat="server" OnClick="btnNext_Click" Text="Nex" Width="118px" />
            </div>
    </form>

</body>
</html>
