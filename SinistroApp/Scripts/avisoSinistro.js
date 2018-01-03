/**
 * Js Aviso Sinistro
 * Criado por Jorge Freitas
 * Data: 04/10/2017
 */

/* Estrutura */
$(document).ready(function () {

    $(function () {

        /* Monta lista dinâmica de observações */
        var addBtn = false;
        var divBtn = $('#sns-div-btn-salvar-obs-avisin');
        var add = $('#sns-btn-add-list-obs-avisin');
        var listContainer = $('#sns-lis-obs-avisin');

        add.on('click', function () {

            var txtObs = $('#sns-obs-avisin');

            if (txtObs.val() == null || txtObs.val() == "") {

                //$('#sns-mensagem-modal-msg-error-avisin').text('Preencha o campo "Observação"!');
                //$('#btn-modal-msg-error').click();

                txtObs.css("border-color", '#F00B0B');
                $('small.sns-validation').removeClass('sns-none');
                txtObs.on('focus', function () {
                    txtObs.css('border-color', '#ccc');
                    $('small.sns-validation').addClass('sns-none');
                })
            }
            else {
                if (addBtn == false) {
                    divBtn.prepend(
                        '<button id="sns-btn-salvar-obs-avisin" type="button" class="btn sns-btn-ok btn-sm">' +
                        '<span class="fa fa-check sns-margin-icon" title="Cadastrar"></span>Salvar Observações' +
                        '</button>');
                }
                addBtn = true;
                event.preventDefault();
                inputValue = $('#sns-obs-avisin').val();
                listContainer.prepend('<li class="list-group-item">' + inputValue + 
                                      '</br><button id="" type="button" class="btn btn-danger btn-sm pull-right sns-icon-list-position">' +
                                      '<span class="fa fa-trash sns-icon-sm-position"></span></button>' +
                                      '<button id="" type="button" class="btn btn-info btn-sm pull-right sns-icon-list-position">' +
                                      '<span class="fa fa-pencil-square-o sns-icon-sm-position"></span></button>' +
                                      '</li >');
                $('#sns-obs-avisin').val('');
            }

        });

    });

});
/* Estrutura */

/* Configuração Datatable Indenização */
$(document).ready(function () {

    var dadosBancariosInd = [];
    var id = 0;

    $.ajax({
        url: '/AvisoSinistro/ListaIndenizacoes',
        type: 'GET',
        dataType: 'json',
        success: function (json) {
            dadosBancariosInd = json.indenizacoes;
        }
    });

    function format(data) {
        return '<div class="details-container">' +
            '<div class="col-md-12 col-sm-12 col-xs-12">' +
            '<label class="lbl-head-title">Banco: </label>' +
            '<label id="sns-indeniza-banco-' + dadosBancariosInd[id].idInd + '" class="lbl-content-description">' + dadosBancariosInd[id].bancoInd + '</label>' +
            '</div>' +
            '<div class="col-md-12 col-sm-12 col-xs-12">' +
            '<label class="lbl-head-title">Agência: </label>' +
            '<label id="sns-indeniza-agencia-' + dadosBancariosInd[id].idInd + '" class="lbl-content-description">' + dadosBancariosInd[id].agenciaInd + '</label>' +
            '</div>' +
            '<div class="col-md-12 col-sm-12 col-xs-12">' +
            '<label class="lbl-head-title">Conta Corrente:</label>' +
            '<label id="sns-indeniza-conta-' + dadosBancariosInd[id].idInd + '" class="lbl-content-description">' + dadosBancariosInd[id].contaInd + '</label>' +
            '</div>' +
            '<div class="col-md-12 col-sm-12 col-xs-12">' +
            '<label class="lbl-head-title">Data Vencimento:</label>' +
            '<label id="sns-indeniza-dtvenc-' + dadosBancariosInd[id].idInd + '" class="lbl-content-description">' + dadosBancariosInd[id].dtVencimentoInd + '</label>' +
            '</div>' +
            '</div>';
    }

    var tableIndenizacao = $('#sns-table-indeniz-avisin').DataTable({
        language: {
            emptyTable: 'Não há registros a serem exibidos',
            zeroRecords: 'Não há registros a serem exibidos',
            thousands: ',',
            processing: 'Processando...',
            loadingRecords: 'Carregando...',
            info: 'Exibindo página _PAGE_ de _PAGES_',
            infoEmpty: 'Exibindo 0 de 0',
            infoFiltered: '(Filtrados de _MAX_ registros)',
            infoPostFix: '',
            lengthMenu: 'Exibir _MENU_ registros por página',
            search: 'Pesquisar:',
            paginate: {
                first: false,
                last: false,
                next: 'Próximo',
                previous: 'Anterior'
            },
            aria: {
                sortAscending: ' Ordenar colunas de forma ascendente',
                sortDescending: ' Ordenar colunas de forma descendente'
            }
        }
    });

    $('#sns-table-indeniz-avisin tbody tr').on('click', 'td.details-control', function () {

        var tr = $(this).closest('tr'),
            row = tableIndenizacao.row(tr);
            id = $(this).attr('id');/*Id da linha clicada. Utilizado como índice para trazer do array, o item correto.*/

        if (row.child.isShown()) {
            tr.next('tr').removeClass('details-row');
            row.child.hide();
            tr.removeClass('shown');
            tr.removeClass('details');
        }
        else {
            row.child(format(row.data())).show();
            tr.next('tr').addClass('details-row');
            tr.addClass('shown');
            tr.addClass('details');
        }
    });

});
/* Configuração Datatable Indenização */

/* Configuração Datatable Despesas */
$(document).ready(function () {

    var dadosBancariosDesp = [];
    var id = 0;

    $.ajax({
        url: '/AvisoSinistro/ListaDespesas',
        type: 'GET',
        dataType: 'json',
        success: function (json) {
            dadosBancariosDesp = json.despesas;
        }
    });

    function format(data) {
        return '<div class="details-container">' +
            '<div class="col-md-12 col-sm-12 col-xs-12">' +
            '<label class="lbl-head-title">Banco: </label>' +
            '<label id="sns-despesa-banco-' + dadosBancariosDesp[id].idDesp + '" class="lbl-content-description">' + dadosBancariosDesp[id].bancoDesp + '</label>' +
            '</div>' +
            '<div class="col-md-12 col-sm-12 col-xs-12">' +
            '<label class="lbl-head-title">Agência: </label>' +
            '<label id="sns-despesa-agencia-' + dadosBancariosDesp[id].idDesp + '" class="lbl-content-description">' + dadosBancariosDesp[id].agenciaDesp + '</label>' +
            '</div>' +
            '<div class="col-md-12 col-sm-12 col-xs-12">' +
            '<label class="lbl-head-title">Conta Corrente:</label>' +
            '<label id="sns-despesa-conta-' + dadosBancariosDesp[id].idDesp + '" class="lbl-content-description">' + dadosBancariosDesp[id].contaDesp + '</label>' +
            '</div>' +
            '<div class="col-md-12 col-sm-12 col-xs-12">' +
            '<label class="lbl-head-title">Data Vencimento:</label>' +
            '<label id="sns-despesa-dtvenc-' + dadosBancariosDesp[id].idDesp + '" class="lbl-content-description">' + dadosBancariosDesp[id].dtVencimentoDesp + '</label>' +
            '</div>' +
            '</div>';
    }

    var tableDespesas = $('#sns-table-desp-avisin').DataTable({
        language: {
            emptyTable: 'Não há registros pra serem exibidos',
            zeroRecords: 'Não há registros pra serem exibidos',
            thousands: ',',
            processing: 'Processando...',
            loadingRecords: 'Carregando...',
            info: 'Exibindo página _PAGE_ de _PAGES_',
            infoEmpty: 'Exibindo 0 de 0',
            infoFiltered: '(Filtrados de _MAX_ registros)',
            infoPostFix: '',
            lengthMenu: 'Exibir _MENU_ registros por página',
            search: 'Pesquisar:',
            paginate: {
                first: false,
                last: false,
                next: 'Próximo',
                previous: 'Anterior'
            },
            aria: {
                sortAscending: ' Ordenar colunas de forma ascendente',
                sortDescending: ' Ordenar colunas de forma descendente'
            }
        }
    });
 
    $('#sns-table-desp-avisin tbody tr').on('click', 'td.details-control', function () {
     
        var tr  = $(this).closest('tr'),
            row = tableDespesas.row(tr);
            id = $(this).attr('id');/*Id da linha clicada. Utilizado como índice para trazer do array, o item correto.*/

        if (row.child.isShown()) {
            tr.next('tr').removeClass('details-row');
            row.child.hide();
            tr.removeClass('shown');
            tr.removeClass('details');
        }
        else {

            row.child(format(row.data())).show();
            tr.next('tr').addClass('details-row');
            tr.addClass('shown');
            tr.addClass('details');
        }
    });

});
/* Configuração Datatable Despesas */





