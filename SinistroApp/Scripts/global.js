/**
 * Js Global
 * Criado por Jorge Freitas
 * Data: 26/09/2017
 */

/* Estrutura */
$(document).ready(function () {

    /* Redirect Login */
    //$('#sns-btn-login').click(function () {
    //    window.location.href = "../";
    //});

    //Desabilita o click dos itens do menu
    //jQuery(".sns-disabled-menu a").on('click', function () {
    //    return false;
    //});

    /* Oculta Div de dados bancários quando combo Meio de Pagamento != Débito */
    var divDadBanc = $('#sns-hid-dados-bancarios');
    var cmbDadBanc = $('.sns-cmb-meio-pagamento');

    divDadBanc.hide();

    $('.sns-cmb-meio-pagamento').on('click', function () {

        var itemSel = cmbDadBanc.val();

        if (itemSel == 3) {
            divDadBanc.show();
        }
        else {
            divDadBanc.hide();
        }
    });

    /* DataTable classe genérica - full */
    var dataTable = $('.sns-datatable').DataTable({

        language: {
            emptyTable: 'Não há registros a serem exibidos',
            zeroRecords: "Sem registros para visualizar",
            thousands: ',',
            processing: 'Processando...',
            loadingRecords: 'Carregando...',
            info: 'Exibindo página _PAGE_ de _PAGES_',
            infoEmpty: 'Sem registros disponíveis',
            infoFiltered: '(Filtrados de _MAX_ registros)',
            infoPostFix: '',
            lengthMenu: 'Exibir _MENU_ registros por página',
            search: 'Pesquisar: ',
            paginate: {
                first: false,//'Primeiro',
                last: false,//'Último',
                next: 'Próximo',
                previous: 'Anterior'
            },
            aria: {
                sortAscending: ' Ordenar colunas de forma ascendente',
                sortDescending: ' Ordenar colunas de forma descendente'
            }
        }
    });
    
    /* DataTable classe genérica - simples(sem busca, paginação, exibição do número de registros...) */
    var sDataTable = $('.sns-simple-table').DataTable({
        lengthMenu: false,
        searching: false,
        ordering: false,
        info: false,
        paginate: false
    });

    /* Seleciona ou deseleciona todos os checkboxes */
    $("#check-all").click(function () {
        if (this.checked) {
            $('.checkbox-all').each(function () {
                this.checked = true;
            })
        } else {
            $('.checkbox-all').each(function () {
                this.checked = false;
            })
        }
    });

    populaCmbEmpresa();
    /* Desabilita combo sucursal no load da tela */
    jQuery("#sns-cmb-sucursal").prop("disabled", true);

    jQuery("#sns-cmb-empresa").on('change', function () {

        var empresaValue = jQuery("#sns-cmb-empresa").find('option:selected').val();

        /* Se combo empresa não foi selecionada, desabilita combo sucursal */
        if (empresaValue == 0) {
            jQuery("#sns-cmb-sucursal").prop("disabled", true);
            jQuery("#sns-cmb-sucursal").val(0);
        }
        else {
            jQuery("#sns-cmb-sucursal").prop("disabled", false);
            populaCmbSucursal(empresaValue);
        }

    })

});
/* Estrutura */

/* Mensagens de tratamento de retorno */
function formataMsgSucesso(msgSucesso,msgTitulo) {
    jQuery('#sns-msg-retorno').addClass('list-group-item-success');
    jQuery('#sns-msg-retorno').removeClass('list-group-item-danger');
    jQuery('#sns-msg-retorno').text(msgSucesso);
    jQuery('#sns-title-modal').text(msgTitulo);
    jQuery('#btn-modal-msg-retorno').click();
}

function formataMsgErro(msgErro, msgTitulo) {
    jQuery('#sns-msg-retorno').removeClass('list-group-item-success');
    jQuery('#sns-msg-retorno').addClass('list-group-item-danger');
    jQuery('#sns-msg-retorno').text(msgErro);
    jQuery('#sns-title-modal').text(msgTitulo);
    jQuery('#btn-modal-msg-retorno').click();
}

/* Formata data dos campos */
function formataDataBr(date) {
    var date = moment(date).locale('pt-br').format('L');
    return date;
}

/* Carrega combo empresa */
function populaCmbEmpresa() {

    jQuery.ajax({
        url: "/OrgaoProdutor/RecuperarEmpresa",
        type: "GET",
        success: function (data) {

            var lstEmpresas = data.listaEmpresas;

            jQuery.each(lstEmpresas, function (index, empresas) {
                var lineContent = "";
                lineContent += "<option value=" + empresas.cdorgprt + ">" + empresas.nmorgprt + "</option>"

                jQuery("#sns-cmb-empresa").append(lineContent);
            })
        },
        error: function (data) {
            var msgTituloErro = 'Erro';
            var msgErro = 'Erro ao popular a combobox "Empresa"!';
            formataMsgErro(msgErro, msgTituloErro);
        }
    });
}

/* Carrega combo sucursal */
function populaCmbSucursal(idEmpresa) {

    jQuery.ajax({
        url: "/OrgaoProdutor/RecuperarSucursalId/" + idEmpresa,
        type: "GET",
        success: function (data) {

            var lstSucursais = data.listaSucursais;

            jQuery("#sns-cmb-sucursal").empty();
            jQuery("#sns-cmb-sucursal").append("<option value='0'>SELECIONE</option>");

            jQuery.each(lstSucursais, function (index, sucursais) {
                var lineContent = "";
                lineContent += "<option value=" + sucursais.cdorgprt + ">" + sucursais.nmorgprt + "</option>";

                jQuery("#sns-cmb-sucursal").append(lineContent);
            })
        },
        error: function (data) {
            var msgTituloErro = 'Erro';
            var msgErro = 'Erro ao popular a combobox "Sucursal"!';
            formataMsgErro(msgErro, msgTituloErro);
        }
    });
}

/* Datepicker */
//$(function () {
//    var bindDatePicker = function () {
//        $(".sns-date").datetimepicker({
//            format: 'DD/MM/YYYY',
//            language: 'pt-BR',
//            icons: {
//                time: "fa fa-clock-o",
//                date: "fa fa-calendar",
//                up: "fa fa-arrow-up",
//                down: "fa fa-arrow-down"
//            }
//        }).find('input:first').on("blur", function () {
//            /*check if the date is correct. We can accept dd-mm-yyyy and yyyy-mm-dd.*/
//            /*update the format if it's yyyy-mm-dd*/
//            var date = parseDate($(this).val());

//            if (!isValidDate(date)) {
//                /*create date based on momentjs (we have that)*/
//                date = moment().format('DD/MM/YYYY');
//            }

//            $(this).val(date);
//        });
//    }

//    var isValidDate = function (value, format) {
//        format = format || false;
//        /*lets parse the date to the best of our knowledge*/
//        if (format) {
//            value = parseDate(value);
//        }

//        var timestamp = Date.parse(value);

//        return isNaN(timestamp) == false;
//    }

//    var parseDate = function (value) {
//        var m = value.match(/^(\d{1,2})(\/|-)?(\d{1,2})(\/|-)?(\d{4})$/);
//        if (m)
//            value = m[5] + '-' + ("00" + m[3]).slice(-2) + '-' + ("00" + m[1]).slice(-2);

//        return value;
//    }

//    bindDatePicker();
//});
/* Datepicker */





