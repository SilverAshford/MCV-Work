let arr = [];

async function fetchData() {
    try {
        const response = await fetch('https://jsonplaceholder.typicode.com/todos');
        const data = await response.json();
        
        arr = data;

        const table = document.querySelector('.tables');

        table.insertAdjacentHTML('beforeend', arr.map(element => `
            <tr style="${element.completed ? 'background-color: #b1e7d6;' : 'background-color: #f7f7ff;'}">
                <td>${element.title}</td>
                <td>${element.completed ? "Completed" : "Pending"}</td>
            </tr>
        `).join(''));

        return data;
    } catch (error) {
        console.error('Error fetching data:', error);
    }
}

fetchData();

console.log("5");

arr.forEach(element => {
    console.log(element);
});