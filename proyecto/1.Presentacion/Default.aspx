<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_1.Presentacion.Default" %>

<!DOCTYPE html>
   
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
 
    <title></title>
   
     <link href="Resources/Style/StyleSheet1.css" rel="stylesheet" />
    <style type="text/css">
        .image {}
        .Losers {
            width: 240px;
        }
    </style>
</head>

<body>
    <form id="form1" runat="server">


        <div class="winnersa">
                        <asp:Label ID="lblname" runat="server"></asp:Label>
                     <asp:Label ID="lblre" runat="server"></asp:Label>
                        <br />
                     <asp:Label ID="lbl2" runat="server"></asp:Label>
                    <asp:Label ID="lbl1" runat="server"></asp:Label>
                        <br />
            <asp:Label ID="lbl3" runat="server"></asp:Label>
                    <asp:Label ID="lbl4" runat="server"></asp:Label>
                         <br />
                         <asp:Label ID="lbl5" runat="server"></asp:Label>
                    <asp:Label ID="lbl6" runat="server"></asp:Label>
                         <br />
                         <asp:Label ID="lbl7" runat="server"></asp:Label>
                    <asp:Label ID="lbl8" runat="server"></asp:Label>
                         <br />
                         <asp:Label ID="lbl9" runat="server"></asp:Label>
                    <asp:Label ID="lbl10" runat="server"></asp:Label>
                         <br />
                         <asp:Label ID="lbl11" runat="server"></asp:Label>
                    <asp:Label ID="lbl12" runat="server"></asp:Label>
                        <br />
                        <asp:Label ID="lbl13" runat="server"></asp:Label>
                    <asp:Label ID="lbl14" runat="server"></asp:Label>
        </div>
    <div class="round1a">
        
        <asp:Label ID="Label2" runat="server" Text="Brazil-10 vs Spain-1 "></asp:Label>
        
        <br />
        <asp:Label ID="Label3" runat="server" Text="Croatia-16 vs Netherlands-9 "></asp:Label>
       
        <br />
        <asp:Label ID="Label4" runat="server" Text="Mexico-20 vs Chile-15 "></asp:Label>
        
        <br />
        <asp:Label ID="Label5" runat="server" Text="Cameroon-51 vs Australia-59"></asp:Label>
       
        <br />
        <asp:Label ID="Label6" runat="server" Text="Colombia-4 vs Uruguay-6 "></asp:Label>
        
        <br />
        <asp:Label ID="Label7" runat="server" Text="Greece-12 vs Costa Rica-31"></asp:Label>
      
        <br />
        <asp:Label ID="Label8" runat="server" Text="Ivory Coast-17 vs England-13"></asp:Label>
        
        <br />
        <asp:Label ID="Label9" runat="server" Text="Japan-48 vs Italy-7"></asp:Label>
         
        <br />
        
        &nbsp; 
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Start" OnClick="Button1_Click1" />
        <br />

        <div class="losers">

            <asp:Label ID="Label13" runat="server" Text="Losers"> </asp:Label>

            <br />
            <br />

            <asp:Label ID="lblLoser1" runat="server"></asp:Label>
            <br />
            <asp:Label ID="lblLoser2" runat="server"></asp:Label>
            <br />
            <asp:Label ID="lblLoser3" runat="server"></asp:Label>
            <br />
            <asp:Label ID="lblLoser4" runat="server"></asp:Label>
            <br />
            <asp:Label ID="lblLoser5" runat="server"></asp:Label>
            <br />
            <asp:Label ID="lblLoser6" runat="server"></asp:Label>
            <br />
            <asp:Label ID="lblLoser7" runat="server"></asp:Label>
            <br />
            <asp:Label ID="lblLoser8" runat="server"></asp:Label>
            <br />
            



        </div>

        <div class="losers2">
            <asp:Label ID="lblLoser9" runat="server"></asp:Label>
            <br />
            <asp:Label ID="lblLoser10" runat="server"></asp:Label>
            <br />
            <asp:Label ID="lblLoser11" runat="server"></asp:Label>
            <br />
            <asp:Label ID="lblLoser12" runat="server"></asp:Label>
            <br />
            <asp:Label ID="lblLoser13" runat="server"></asp:Label>
            <br />
            <asp:Label ID="lblLoser14" runat="server"></asp:Label>
            <br />
            <asp:Label ID="lblLoser15" runat="server"></asp:Label>
            <br />
            <asp:Label ID="lblLoser16" runat="server"></asp:Label>
        </div>
    </div>

        <div class="winnersb">
            <asp:Label ID="lbl15" runat="server"></asp:Label>
         <asp:Label ID="lbl16" runat="server"></asp:Label>
            <br />
            <asp:Label ID="lbl17" runat="server"></asp:Label>
         <asp:Label ID="lbl18" runat="server"></asp:Label>
                    <br />
                    <asp:Label ID="lbl19" runat="server"></asp:Label>
         <asp:Label ID="lbl20" runat="server"></asp:Label>
            <br />
       <asp:Label ID="lbl21" runat="server"></asp:Label>
         <asp:Label ID="lbl22" runat="server"></asp:Label>
            <br />
    <asp:Label ID="lbl23" runat="server"></asp:Label>
         <asp:Label ID="lbl24" runat="server"></asp:Label>
            <br />
            <asp:Label ID="lbl25" runat="server"></asp:Label>
         <asp:Label ID="lbl26" runat="server"></asp:Label>
                    <br />
                    <asp:Label ID="lbl27" runat="server"></asp:Label>
         <asp:Label ID="lbl28" runat="server"></asp:Label>
            <br />
            <asp:Label ID="lbl29" runat="server"></asp:Label>
         <asp:Label ID="lbl30" runat="server"></asp:Label>
        </div>

        <div class="round1b">
        
          
         <asp:Label ID="Label10" runat="server" Text="Switzerland-8 vs Argentina-3 "></asp:Label>
        
            <br />
        
        
        <asp:Label ID="Label12" runat="server" Text="Ecuador-23 vs Bonia-Herzegovina-21"></asp:Label>
       
            <br />

        <asp:Label ID="Label14" runat="server" Text="France-19 vs Iran-45"></asp:Label>
            <br />
        
       
         <asp:Label ID="Label15" runat="server" Text="Honduras-41 vs Nigeria-36"></asp:Label>
            <br />
    
     
        <asp:Label ID="Label16" runat="server" Text="Germany-2 vs Belgium-11"></asp:Label>
      
            <br />
        
       
        <asp:Label ID="Label17" runat="server" Text="Portugal-5 vs Algeria-26"></asp:Label>
            <br />

       
        <asp:Label ID="Label18" runat="server" Text="Ghana-24 vs Russia-22"></asp:Label>
            <br />
        
        
        <asp:Label ID="Label19" runat="server" Text="United States14 vs South Korea-54"></asp:Label>
            <br />
            <br />
    </div>

        <div class="title">
        <asp:Label ID="Label1" runat="server" Text="World Cup Simulation "></asp:Label>
        </div>


            <div class="imagen" >
        <asp:Image ID="Image1" runat="server" ImageUrl="~/Resources/Images/wc1.png" CssClass="image" Height="174px" />
           
        </div>


        <div class="summary">

            <br />
            
            <asp:Button ID="btnNext" runat="server" Text="Next Round" OnClick="btnNext_Click" Width="115px" />
        </div>
        <p>
         
        </p>

        <div class="winners">

            <asp:Label ID="Label11" runat="server" Text="Winners"></asp:Label>
        </div>

    </form>

    
         
</body>
</html>
