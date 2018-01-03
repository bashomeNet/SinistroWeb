/**
 * Js Pre Aviso
 * Criado por Jorge Freitas
 * Data: 03/10/2017
 */

/* Estrutura */
$(document).ready(function () {

    var dadosPreAviso = [];
    var id = 0;

    $.ajax({
        url: '/PreAviso/ListaPreAvisos',
        type: 'GET',
        dataType: 'json',
        success: function (json) {
            dadosPreAviso = json.preAvisos;
        }
    });

    function format(data) {

        return '<div class="details-container tap-panel-hide" role="tabpanel" data-example-id="togglable-tabs' + dadosPreAviso[id].idPreAviso + '">' +
            '<ul id="sns-tab-preavis' + dadosPreAviso[id].idPreAviso + '" class="nav nav-tabs bar_tabs" role="tablist">' +
            '<li role="presentation" class="active"><a href="#tab_content_detalhes' + dadosPreAviso[id].idPreAviso + '" id="detalhes-tab' + dadosPreAviso[id].idPreAviso + '" role="tab" data-toggle="tab" aria-expanded="true">Detalhes</a>' +
            '</li>' +
            '<li role="presentation" class=""><a href="#tab_content_criticas' + dadosPreAviso[id].idPreAviso + '" role="tab" id="criticas-tab' + dadosPreAviso[id].idPreAviso + '" data-toggle="tab" aria-expanded="false">Críticas</a>' +
            '</li>' +
            '<li role="presentation" class=""><a href="#tab_content_certificado' + dadosPreAviso[id].idPreAviso + '" role="tab" id="certificados-tab' + dadosPreAviso[id].idPreAviso + '" data-toggle="tab" aria-expanded="false">Todos os certificados</a>' +
            '</li>' +
            '<li role="presentation" class=""><a href="#tab_content_coberturas' + dadosPreAviso[id].idPreAviso + '" role="tab" id="certificados-tab' + dadosPreAviso[id].idPreAviso + '" data-toggle="tab" aria-expanded="false">Coberturas</a>' +
            '</li>' +
            '</ul>' +
            '<div id="sns-tab-content-preavis' + dadosPreAviso[id].idPreAviso + '" class="tab-content">' +
            '<div role="tabpanel" class="tab-pane fade active in" id="tab_content_detalhes' + dadosPreAviso[id].idPreAviso + '" aria-labelledby="detalhes-tab">' +
            '<div class="col-md-12 col-sm-12 co-xs-12">' +
            '<label class="lbl-head-title">Nome do Titular: </label>' +
            '<label id="sns-tab1-nm-titular-preavis' + dadosPreAviso[id].idPreAviso + '" class="lbl-content-description">' + dadosPreAviso[id].nmTitular + '</label>' +
            '</div>' +
            '<div class="col-md-12 col-sm-12 co-xs-12">' +
            '<label class="lbl-head-title">Grau de Parentesco: </label>' +
            '<label id="sns-tab1-gr-parent-preavis' + dadosPreAviso[id].idPreAviso + '" class="lbl-content-description">' + dadosPreAviso[id].grParentTitular + '</label>' +
            '</div>' +
            '<div class="col-md-12 col-sm-12 co-xs-12">' +
            '<label class="lbl-head-title">Nº Contrato / Certificado / Proposta:</label>' +
            '<label id="sns-tab1-contrato-preavis' + dadosPreAviso[id].idPreAviso + '" class="lbl-content-description">' + dadosPreAviso[id].contratoTitular + ' / </label>' +
            '<label id="sns-tab1-certif-preavis' + dadosPreAviso[id].idPreAviso + '" class="lbl-content-description">' + dadosPreAviso[id].certificadoTitular + ' / </label>' +
            '<label id="sns-tab1-proposta-preavis' + dadosPreAviso[id].idPreAviso + '" class="lbl-content-description">' + dadosPreAviso[id].propostaTitular + '</label>' +
            '</div>' +
            '<div class="col-md-12 col-sm-12 co-xs-12">' +
            '<label class="lbl-head-title">Data do Evento:</label>' +
            '<label id="sns-tab1-dt-evento-preavis' + dadosPreAviso[id].idPreAviso + '" class="lbl-content-description">' + dadosPreAviso[id].dtSinistro + '</label>' +
            '</div>' +
            '<div class="col-md-12 col-sm-12 co-xs-12">' +
            '<label class="lbl-head-title">Causa Mortis:</label>' +
            '<label id="sns-tab1-cs-mortis-preavis' + dadosPreAviso[id].idPreAviso + '" class="lbl-content-description">' + dadosPreAviso[id].csMortis + '</label>' +
            '</div>' +
            '<div class="col-md-12 col-sm-12 co-xs-12">' +
            '<label class="lbl-head-title">Serviço Realizado:</label>' +
            '<label id="sns-tab1-sv-realizado-preavis' + dadosPreAviso[id].idPreAviso + '" class="lbl-content-description">' + dadosPreAviso[id].svcRealizado + '</label>' +
            '</div>' +
            '<div class="col-md-12 col-sm-12 co-xs-12">' +
            '<label class="lbl-head-title">Motivo do Não Atendimento:</label>' +
            '<label id="sns-tab1-mt-natend-preavis' + dadosPreAviso[id].idPreAviso + '" class="lbl-content-description">' + dadosPreAviso[id].motNaoAtendimento + '</label>' +
            '</div>' +
            '<div class="col-md-12 col-sm-12 co-xs-12">' +
            '<label class="lbl-head-title">Telefone / Nome / Grau de Parentesco:</label>' +
            '<label id="sns-tab1-nr-tel-preavis' + dadosPreAviso[id].idPreAviso + '" class="lbl-content-description">' + dadosPreAviso[id].telContato + ' / </label>' +
            '<label id="sns-tab1-nome-preavis' + dadosPreAviso[id].idPreAviso + '" class="lbl-content-description">' + dadosPreAviso[id].nmContato + ' / </label>' +
            '<label id="sns-tab1-gr-parent-contato-preavis' + dadosPreAviso[id].idPreAviso + '" class="lbl-content-description">' + dadosPreAviso[id].grParentContato + '</label>' +
            '</div>' +
            '</div>' +
            '<div role="tabpanel" class="tab-pane fade" id="tab_content_criticas' + dadosPreAviso[id].idPreAviso + '" aria-labelledby="criticas-tab">' +
            '<div class="col-md-12 col-sm-12 co-xs-12">' +
            '<label class="lbl-head-title">Evento Preenchido: </label>' +
            '<label id="sns-tab2-ev-preenc-preavis' + dadosPreAviso[id].idPreAviso + '" class="lbl-content-description">' + dadosPreAviso[id].stEvento + '</label>' +
            '</div>' +
            '<div class="col-md-12 col-sm-12 co-xs-12">' +
            '<label class="lbl-head-title">Carência: </label>' +
            '<label id="sns-tab2-carencia-preavis' + dadosPreAviso[id].idPreAviso + '" class="lbl-content-description">' + dadosPreAviso[id].stCarencia + '</label>' +
            '</div>' +
            '<div class="col-md-12 col-sm-12 co-xs-12">' +
            '<label class="lbl-head-title">Inadimplente: </label>' +
            '<label id="sns-tab2-inadimp-preavis' + dadosPreAviso[id].idPreAviso + '" class="lbl-content-description">' + dadosPreAviso[id].stAdimplencia + '</label>' +
            '</div>' +
            '<div class="col-md-12 col-sm-12 co-xs-12">' +
            '<label class="lbl-head-title">Situação Certificado: </label>' +
            '<label id="sns-tab2-st-certif-preavis' + dadosPreAviso[id].idPreAviso + '" class="lbl-content-description">' + dadosPreAviso[id].stCertificado + '</label>' +
            '</div>' +
            '<div class="col-md-12 col-sm-12 co-xs-12">' +
            '<label class="lbl-head-title">Tempo de seguro: </label>' +
            '<label id="sns-tab2-tmp-seguro-preavis' + dadosPreAviso[id].idPreAviso + '" class="lbl-content-description">' + dadosPreAviso[id].tmpSeguro + '</label>' +
            '</div>' +
            '</div>' +
            '<div role="tabpanel" class="tab-pane fade" id="tab_content_certificado' + dadosPreAviso[id].idPreAviso + '" aria-labelledby="certificados-tab">' +
            '<div class="table-responsive col-md-6 col-sm-6 co-xs-12">' +
            '<table id="sns-table-ceritf-preavis' + dadosPreAviso[id].idPreAviso + '" class="table table-striped table-bordered sns-simple-table headings">' +
            '<thead>' +
            '<tr class="headings">' +
            '<th class="column-title">#</th>' +
            '<th class="column-title">Contrato </th>' +
            '<th class="column-title">Certificado </th>' +
            '</tr>' +
            '</thead>' +
            '<tbody>' +
            '<tr class="even pointer">' +
            '<td class=" ">' + dadosPreAviso[id].idPreAviso + '</td>' +
            '<td class=" ">' + dadosPreAviso[id].contrato + '</td>' +
            '<td class=" ">' + dadosPreAviso[id].certificado + '</td>' +
            '</tr>' +
            '<tr class="odd pointer">' +
            '<td class=" ">' + dadosPreAviso[id].idPreAviso + '</td>' +
            '<td class=" ">' + dadosPreAviso[id].contrato + '</td>' +
            '<td class=" ">' + dadosPreAviso[id].certificado + '</td>' +
            '</tr>' +
            '<tr class="even pointer">' +
            '<td class=" ">' + dadosPreAviso[id].idPreAviso + '</td>' +
            '<td class=" ">' + dadosPreAviso[id].contrato + '</td>' +
            '<td class=" ">' + dadosPreAviso[id].certificado + '</td>' +
            '</tr>' +
            '</tbody>' +
            '</table>' +
            '</div>' +
            '</div>' +
            '<div role="tabpanel" class="tab-pane fade" id="tab_content_coberturas' + dadosPreAviso[id].idPreAviso + '" aria-labelledby="coberturas-tab">' +
            '<div class="table-responsive col-md-11 col-sm-12 col-xs-12" style="margin: 25px auto">' +
            '<table id="sns-table-coberturas-preavis' + dadosPreAviso[id].idPreAviso + '" class="table table-striped table-bordered sns-simple-table headings" cellspacing="0">' +
            '<thead>' +
            '<tr class="headings">' +
            '<th></th>' +
            '<th class="column-title">Cobertura </th>' +
            '<th class="column-title">Valor IS </th>' +
            '<th class="column-title">Estimativa Indenização </th>' +
            '<th class="column-title">Ramo </th>' +
            '<th class="column-title">Data Início Vigência </th>' +
            '<th class="column-title">Data Fim Vigência </th>' +
            '</tr>' +
            '</thead>' +
            '<tbody>' +
            '<tr class="even pointer">' +
            '<td class="a-center "><input type="checkbox" class="checkbox-all"></td>' +
            '<td class=" ">Cobertura 1</td>' +
            '<td class=" ">R$ 111,11</td>' +
            //'<td class="td-input-info"><input id="sns-txt-est-indeniz-preavis' + dadosPreAviso[id].idPreAviso + '" type="text" class="form-control input-sm" value=" "></td>' +
            '<td class=" ">' + dadosPreAviso[id].estIndenizacao + '</td>' +
            '<td class=" ">Ramo 1</td>' +
            '<td class=" ">01/01/0001</td>' +
            '<td class=" ">02/01/0001</td>' +
            '</tr>' +
            '<tr class="odd pointer">' +
            '<td class="a-center "><input type="checkbox" class="checkbox-all"></td>' +
            '<td class=" ">' + dadosPreAviso[id].cobertura + '</td>' +
            '<td class=" ">R$ ' + dadosPreAviso[id].vlIs + '</td>' +
            //'<td class="td-input-info"><input id="sns-txt-est-indeniz-preavis' + dadosPreAviso[id].idPreAviso + '" type="text" class="form-control input-sm" value=" "></td>' +
            '<td class=" ">' + dadosPreAviso[id].estIndenizacao + '</td>' +
            '<td class=" ">' + dadosPreAviso[id].ramo + '</td>' +
            '<td class=" ">' + dadosPreAviso[id].dtIniVigencia + '</td>' +
            '<td class=" ">' + dadosPreAviso[id].dtFimVigencia + '</td>' +
            '</tr>' +
            '<tr class="even pointer">' +
            '<td class="a-center "><input type="checkbox" class="checkbox-all"></td>' +
            '<td class=" ">Cobertura 3</td>' +
            '<td class=" ">R$ 333,33</td>' +
            //'<td class="td-input-info"><input id="sns-txt-est-indeniz-preavis' + dadosPreAviso[id].idPreAviso + '" type="text" class="form-control input-sm" value=" "></td>' +
            '<td class=" ">' + dadosPreAviso[id].estIndenizacao + '</td>' +
            '<td class=" ">Ramo 3</td>' +
            '<td class=" ">03/03/0003</td>' +
            '<td class=" ">04/03/0003</td>' +
            '</tr>' +
            '</tbody>' +
            '</table>' +
            '</div>' +
            '</div>' +
            '<div class="form-group col-md-12 col-sm-12 col-xs-12" style="margin: 20px 0;">' +
            '<button id="sns-btn-recusa-preavis-' + dadosPreAviso[id].idPreAviso + '" type="button" class="btn sns-btn-no btn-sm" data-toggle="modal" data-target=".sns-modal-reprova-preavis"><span class="fa fa-times sns-margin-icon sns-icon-sm-position" title="Reprovar"></span>Reprovar Pré Aviso</button>' +
            '<button id="sns-btn-gera-preavis-' + dadosPreAviso[id].idPreAviso + '" type="submit" class="btn sns-btn-ok btn-sm"><span class="fa fa-check sns-margin-icon sns-icon-sm-position" title="Gerar"></span>Gerar Aviso</button>' +
            '</div>' +
            '</div>' +
            '</div>';
    }

    var tablePreAviso = $('#sns-table-pre-aviso').DataTable({
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

    $('#sns-table-pre-aviso tbody tr').on('click', 'td.details-control', function () {

        var tr = $(this).closest('tr'),
            row = tablePreAviso.row(tr);
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

    /* Carrega combo situação PreAviso */
    function populaCmbSituacaoPreAviso() {

        jQuery.ajax({
            url: "/PreAviso/RecuperarSituacoesPreAviso",
            type: "GET",
            success: function (data) {

                var lstSituacoes = data.listaSituacoes;

                jQuery.each(lstSituacoes, function (index, situacao) {
                    var lineContent = "";
                    lineContent += "<option value=" + situacao.ds_vlrdmn + ">" + situacao.ds_sgncam + "</option>"

                    jQuery("#sns-cmb-situacao-pre-aviso").append(lineContent);
                })
            },
            error: function (data) {
                var msgTituloErro = 'Erro';
                var msgErro = 'Erro ao popular a combobox "Situação"!';
                formataMsgErro(msgErro, msgTituloErro);
            }
        });
    }
    populaCmbSituacaoPreAviso();
});
/* Estrutura */





