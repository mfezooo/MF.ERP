var dataTable;
let controllerName = "/RepresintiveTarget";
$(document).ready(function () {
    loadDataTable();

});
$(document).on('click', ".btnCreate", function () {
    clear();
    drawModel("CreateNew");
});
function clear() {
    $('#sId').val(0);
    $('#nameInput').val('');
    $('#representiveId').val(0);
    $('#targetTypeId').val(0);
    $('#startTargetTime').val(1);
    $('#endTargetTime').val(0);
    $('#amount').val(0);  
 
}

$(document).on('click', ".btnEdit", function () {
    clear();
    let sid = $(this).attr('sid');
    getEntityById(controllerName, sid, fillNameArEn, showErrorMessage)

});
$(document).on('click', ".btnDelete", function () {
    clear();
    let sid = $(this).attr('sid');
    deleteById(controllerName, sid, deleteEntity, showErrorMessage)

});
function fillNameArEn(entity) {
    $('#sId').val(entity.id);
    $('#representiveId').val(entity.representiveId);
    $('#targetTypeId').val(entity.targetTypeId);  

    let startDate = new Date(entity.startTargetTime); 
    startDate.setDate(startDate.getDate() + 1);
    let endTargetTime = new Date(entity.endTargetTime); 
    endTargetTime.setDate(endTargetTime.getDate() + 1);

    document.getElementById("startTargetTime").valueAsDate = startDate;
    document.getElementById("endTargetTime").valueAsDate = endTargetTime;
    $('#amount').val(entity.amount);  
    drawModel("Edit");
}

function deleteEntity(data) {
    if (data.isSuccess) {
        showSuccessMessage();
        loadDataTable();
    }
}
function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": {
            "url": controllerName + "/GetAll", "dataSrc": ""
        },
        "order": [[0, 'desc']],
        "columns": [
            { "data": "id", "width": "10%" },
            { "data": "representiveName" },
            { "data": "targetTypeName" },
            { "data": "startTargetTimeStr" },
            { "data": "endTargetTimeStr" },
            { "data": "amount" },
            {
                title: "", "width": "10%",
                render: function (data, type, full) {
                    return `  
  <a class="btn btn-outline-primary btn-sm btnEdit" sid='${full.id}' data-toggle="modal" > <i class="fa fa-edit"></i> </a>
  <a class="btn btn-outline-danger btn-sm btnDelete" sid='${full.id}' data-toggle="modal" ><i class="fa-solid fa-trash  "></i></a> 
                        `
                },
            },
        ],
        "bDestroy": true
    });
}
// this is the id of the form
$("#frmCreate").submit(function (e) {

    e.preventDefault(); // avoid to execute the actual submit of the form.

    var form = $(this);
    let actionUrls = controllerName + "/Create";
    //var actionUrl = form.attr('action');

    $.ajax({
        type: "POST",
        url: actionUrls,
        data: form.serialize(), // serializes the form's elements.
        success: function (data) {
            if (data.isSuccess) {
                showSuccessMessage();
                loadDataTable();
                hideModel();
            } else {
                showErrorMessage();
            }
        }
    });

});

function drawModel(mTitle, mData, callBack = null) {

    if (mTitle === 'CreateNew') {
        $('#ModalTitleCreate').removeClass('d-none');
        $('#ModalTitleEdit').addClass('d-none');
    }
    else {
        $('#ModalTitleCreate').addClass('d-none');
        $('#ModalTitleEdit').removeClass('d-none');
    }
    $('#exampleModalLongTitle').text(mTitle);

    $('#results').html(mData);

    $('#exampleModalCenter').modal('show');
    if (callBack != null) {
        callBack();
    }
}
function hideModel() {

    $('#exampleModalCenter').modal('hide');
}
