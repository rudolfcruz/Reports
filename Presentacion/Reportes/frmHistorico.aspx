<%@ Page Language="C#" MasterPageFile="~/PaginaMaestra/PageMaster.Master" AutoEventWireup="true" CodeBehind="frmHistorico.aspx.cs" Inherits="Presentacion.Reportes.frmHistorico" validateRequest="false" enableEventValidation="false"%>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">    
<script type="text/javascript">
    function AgregaCampoTablaSel_Click(id, obj) {

        $("#contenedorRepHist").empty(); //Vacia el contenedor de filtros para que no truene el llamado al generar reporte
        $('#contenedorRepHist').attr({ src: "" + obj.href });
        return false;
    }


    function AbreVentanaMapa(idHistorial, nombreRep) {
        window.open("http://WIN-9FPINIQC47N/AppBarandillas/Remision/MapReport.aspx?" + encodeURI("HistoricoID=" + idHistorial + "&TituloReporte=" + nombreRep), '_blank');
        return false;
    }
</script>
        <asp:Panel runat="server" ID="PanelHistorico">
        </asp:Panel>
    <iframe id="contenedorRepHist" frameborder="0" height="10" width="10" scrolling="no" >
    </iframe>
</asp:Content>
