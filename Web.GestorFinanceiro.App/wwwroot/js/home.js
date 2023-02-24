var options = {
    series: [
        {
            name: 'Atual',
            data: [
                {
                    x: 'Alimentação',
                    y: 956.77,
                    goals: [
                        {
                            name: 'Esperado',
                            value: 1250.15,
                            strokeWidth: 5,
                            strokeHeight: 15,
                            strokeColor: '#775DD0'
                        }
                    ]
                },
                {
                    x: 'Compras',
                    y: 456.98,
                    goals: [
                        {
                            name: 'Esperado',
                            value: 400,
                            strokeWidth: 5,
                            strokeHeight: 15,
                            strokeColor: '#775DD0'
                        }
                    ]
                },
                {
                    x: 'Mobilidade',
                    y: 245.98,
                    goals: [
                        {
                            name: 'Esperado',
                            value: 300,
                            strokeWidth: 5,
                            strokeHeight: 15,
                            strokeColor: '#775DD0'
                        }
                    ]
                },
                {
                    x: 'Contas',
                    y: 780.90,
                    goals: [
                        {
                            name: 'Esperado',
                            value: 750,
                            strokeWidth: 5,
                            strokeHeight: 15,
                            strokeColor: '#775DD0'
                        }
                    ]
                },
                {
                    x: 'Entretenimento',
                    y: 342.97,
                    goals: [
                        {
                            name: 'Esperado',
                            value: 250,
                            strokeWidth: 5,
                            strokeHeight: 15,
                            strokeColor: '#775DD0'
                        }
                    ]
                },
                {
                    x: 'Outros',
                    y: 439.21,
                    goals: [
                        {
                            name: 'Esperado',
                            value: 400,
                            strokeWidth: 5,
                            strokeHeight: 15,
                            strokeColor: '#775DD0'
                        }
                    ]
                }
            ]
        }
    ],
    chart: {
        height: 300,
        type: 'bar'
    },
    plotOptions: {
        bar: {
            horizontal: true,
        }
    },
    colors: ['#ff5500'],
    dataLabels: {
        formatter: function (val, opt) {
            const goals =
                opt.w.config.series[opt.seriesIndex].data[opt.dataPointIndex]
                    .goals

            if (goals && goals.length) {
                return `${val} / ${goals[0].value}`
            }
            return val
        }
    },
    legend: {
        show: true,
        showForSingleSeries: true,
        customLegendItems: ['Gasto R$', 'Expectativa de Gasto R$'],
        markers: {
            fillColors: ['#ff5500', '#775DD0']
        }
    }
};

var chart = new ApexCharts(document.querySelector("#chart-gastos-meta"), options);
chart.render();

var options = {
    series: [44, 55],
    chart: {
        width: 440,
        type: 'pie',
    },
    labels: ['Gasto', 'Renda'],
    responsive: [{
        breakpoint: 480,
        options: {
            chart: {
                width: 200
            },
            legend: {
                position: 'right'
            }
        }
    }]
};

var chart = new ApexCharts(document.querySelector("#chart-despesa-renda-mensal"), options);
chart.render();

var options = {
    series: [{
        name: 'Consumido',
        data: [13, 23, 34]
    }, {
        name: 'Disponível',
        data: [54, 55, 41]
    }],
    chart: {
        type: 'bar',
        height: 330,
        stacked: true,
        stackType: '100%'
    },
    responsive: [{
        breakpoint: 480,
        options: {
            legend: {
                position: 'bottom',
                offsetX: -10,
                offsetY: 0
            }
        }
    }],
    xaxis: {
        categories: ['Nubank', 'Itaú', 'C6 Bank'],
    },
    fill: {
        opacity: 1,
    },
    legend: {
        position: 'right',
        offsetX: 0,
        offsetY: 50
    },
};

var chart = new ApexCharts(document.querySelector("#chart-cartoes-credito"), options);
chart.render();

new gridjs.Grid({
    sort: true,
    search: true,
    pagination: {
        limit: 5
    },
    columns: ["Nome da Despesa", "Valor", "Data", "Status"],
    data: [
        ["Energia", "R$202,98", "11/02/2022", "Pago"],
        ["Internet", "R$99,90", "16/02/2022", "Pago"],
        ["Água", "R$77,12", "25/02/2022", "Pendente"],
        ["Aluguel", "R$1.467,00", "20/02/2022", "Atraso"],
        ["Netflix", "R$32,00", "-", "Não informado"]
    ]
}).render(document.getElementById("wrapper"));

$(document).ready(function () {

    var data = new Date();
    var valorHora = data.getHours();

    if (valorHora >= 4 && valorHora < 12) {
        $('#cumprimento').prepend("Bom dia,");
    }
    else if (valorHora >= 12 && valorHora < 18) {
        $('#cumprimento').prepend("Boa tarde,");
    }
    else {
        $('#cumprimento').prepend("Boa noite,");
    }
});