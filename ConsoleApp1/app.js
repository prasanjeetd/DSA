/*
 var data ={
    

    const data = {
      "headers": [
        "Range",
        "Top speed",
        "Acceleration to 100km/h"
      ],
      "data": {
        "Electric car 1": [
          "400 km",
          "209 km/h",
          "5.6 seconds"
        ],
        "Electric car 2": [
          "256 km",
          "130 km/h",
          "11.9 seconds"
        ]
      }
    };

    const tableHTML = generateTable(data);
    console.log(tableHTML);
  "headers": [
    "Range",
    "Top speed",
    "Acceleration to 100km/h"
  ],
  "data": {
    "Electric car 1": [
      "400 km",
      "209 km/h",
      "5.6 seconds"
    ],
    "Electric car 2": [
      "256 km",
      "130 km/h",
      "11.9 seconds"
    ]
  }


  should result 

  <table>
    <tr>
        <td></td>
        <th>Range</th>
        <th>Top speed</th>
        <th>Acceleration to 100km/h</th>
    </tr>
    <tr>
        <th>Electric car 1</th>
        <td>400 km</td>
        <td>209 km/h</td>
        <td>5.6 seconds</td>
    </tr>
    <tr>
        <th>Electric car 2</th>
        <td>256 km</td>
        <td>130 km/h</td>
        <td>11.9 seconds</td>
    </tr>
</table>

*/

function generateTable(data) {
    let tableHTML = '<table>\n';

    // Generate table headers
    tableHTML += '  <tr>\n';
    tableHTML += '    <td></td>\n';
    for (let header of data.headers) {
        tableHTML += `    <th>${header}</th>\n`;
    }
    tableHTML += '  </tr>\n';

    // Generate table rows
    for (let car in data.data) {
        tableHTML += '  <tr>\n';
        tableHTML += `    <th>${car}</th>\n`;
        for (let value of data.data[car]) {
            tableHTML += `    <td>${value}</td>\n`;
        }
        tableHTML += '  </tr>\n';
    }

    tableHTML += '</table>';

    return tableHTML;
}