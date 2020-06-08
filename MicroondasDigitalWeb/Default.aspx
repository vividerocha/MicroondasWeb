<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MicroondasDigitalWeb._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        #microondas{
            background-color:#89cbfb;
            width:1000px;
            height:600px;
            border-radius:15px;
            padding-top:30px;
            margin-left:30px;
        }
        #painel{
            background-color:#c9e8fe;
            border:3px solid #277ebd;
            width:600px;
            height:550px;
            border-radius:15px;
            margin-left:20px;
            padding-top:100px;
            padding-left:80px;
            float:left;
        }
        #botoes{
            background-color:#fbed9e;
            width:300px;
            height:550px;
            border-radius:15px;
            margin-left:20px;
            padding-top:15px;
            float:left;
        }
        #cron{
            background-color:#fff;
            width:280px;
            height:80px;
            border-radius:15px;
            margin-left:15px;
            padding-left:15px;
            margin-bottom:40px;
            font-size:16pt;
        }
        #painelB{
            width:280px;
            height:50px;
            border-radius:15px;
            margin-left:25px;
            padding-left:15px;
        }
    </style>
    <div class="jumbotron">
        <h2>Microondas Digital Web</h2>
        <h4>Essa é uma aplicação web que simula um microondas</h4>
    </div>

    <div class="row">
        <div class="col-md-12">
            <div id="microondas">
                <div id="painel">                              
                                
                    <asp:Label ID="lblMensagem" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="#990000"></asp:Label>
                                
                </div>
                <div id="botoes">
                    <div id="cron">
                            <asp:Timer ID="Timer1" runat="server" Interval="1000" OnTick="Timer1_Tick">
                            </asp:Timer>
                            <asp:UpdatePanel ID="up" runat="server" UpdateMode="Conditional">
                                <ContentTemplate>
                                    <asp:Literal ID="cronometro" runat="server"></asp:Literal>
                                </ContentTemplate>
                                
                                <Triggers>
                                    <asp:AsyncPostBackTrigger ControlID="Timer1" EventName="tick" />
                                </Triggers>
                            </asp:UpdatePanel>
                        <asp:Label ID="lblRotPotencia" Text="Potência: " runat="server" Font-Bold="True" Font-Size="Large"></asp:Label>
                        <asp:Label ID="lblPotencia" runat="server" Font-Bold="True" Font-Size="Large"></asp:Label>
                        <asp:Label ID="lblCaractereAquecimento" Visible="False" Text="@" runat="server" Font-Bold="True" Font-Size="X-Large"></asp:Label>
                    </div>
                    <div id="painelB">
                        <asp:Button ID="btn1" runat="server" Text="1" Width="70px" OnClick="btn1_Click"/>
                        <asp:Button ID="btn2" runat="server" Text="2" Width="70px" OnClick="btn2_Click"/>
                        <asp:Button ID="btn3" runat="server" Text="3" Width="70px" OnClick="btn3_Click"/>
                        <br />
                        <asp:Button ID="btn4" runat="server" Text="4" Width="70px" OnClick="btn4_Click"/>
                        <asp:Button ID="btn5" runat="server" Text="5" Width="70px" OnClick="btn5_Click"/>
                        <asp:Button ID="btn6" runat="server" Text="6" Width="70px" OnClick="btn6_Click"/>
                        <br />
                        <asp:Button ID="btn7" runat="server" Text="7" Width="70px" OnClick="btn7_Click"/>
                        <asp:Button ID="btn8" runat="server" Text="8" Width="70px" OnClick="btn8_Click"/>
                        <asp:Button ID="btn9" runat="server" Text="9" Width="70px" OnClick="btn9_Click"/>
                        <br />
                        <asp:Button ID="btn0" runat="server" Text="0" Width="70px" OnClick="btn0_Click"/>
                        <asp:Button ID="btnPeixe" runat="server" Text="Peixe" Width="70px" OnClick="btnPeixe_Click"/>
                        <asp:Button ID="btnFrango" runat="server" Text="Frango" Width="70px" OnClick="btnFrango_Click"/>
                        <br />
                        <asp:Button ID="btnPipoca" runat="server" Text="Pipoca" Width="70px" OnClick="btnPipoca_Click"/>
                        <asp:Button ID="btnCarne" runat="server" Text="Carne" Width="70px" OnClick="btnCarne_Click"/>
                        <asp:Button ID="btnSopa" runat="server" Text="Sopa" Width="70px" OnClick="btnSopa_Click"/>
                        <br />
                        <asp:Button ID="Button1" runat="server" Text="Iniciar" OnClick="Button1_Click1" Width="70px"/>
                        <asp:Button ID="Button2" runat="server" Text="Pausar" OnClick="Button2_Click" Width="70px"/>
                        <asp:Button ID="Button3" runat="server" Text="Zerar" Width="70px" OnClick="Button3_Click"/>
                        <br />

                        <asp:Button ID="btnPotencia" runat="server" Text="Potencia" Width="70px" OnClick="btnPotencia_Click"/>
        
                    
                    </div>
            </div>
        </div>
    </div>

    </div>
</asp:Content>
