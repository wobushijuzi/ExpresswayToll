var TableDatatablesManaged = function () {
    var initTable1 = function () {
        var table = $('#List');
        table.dataTable({
            "language": {
                "aria": {
                    "sortAscending": ": ��������",
                    "sortDescending": ": ��������"
                },
                "emptyTable": "������",
                "info": "�� _TOTAL_ ������ǰ��ʾ _START_ - _END_ ��",
                "infoEmpty": "������",
                "infoFiltered": "(�� _MAX_ ���м���)",
                "lengthMenu": "ÿҳ��ʾ _MENU_ ��",
                "search": "����:",
                "zeroRecords": "��ѯ��������ָ������������",
                "paginate": {
                    "previous": "��һҳ",
                    "next": "��һҳ",
                    "last": "ĩҳ",
                    "first": "��ҳ"
                }
            },

            "bStateSave": true, 

            "lengthMenu": [
                [5, 15, 20, -1],
                [5, 15, 20, "All"] 
            ],
            "pageLength": 5,
            "order": [
                [1, "asc"]
            ] 
        });
      }
        return {

            //main function to initiate the module
            init: function () {
                if (!jQuery().dataTable) {
                    return;
                }
                initTable1();
            }
        };
    }();

    if (App.isAngularJsApp() === false) {
        jQuery(document).ready(function () {
            TableDatatablesManaged.init();
        });
    }
