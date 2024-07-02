const fs = require('fs');
const path = require('path');

function BankTransactionAnalyzerSimple(filePath) {
	try {
		const data = fs.readFileSync(filePath, 'utf8');
		const lines = data.split('\n');
		let total = 0;

		lines.forEach(line => {
			const columns = line.split(',');

			if (columns[1]) {
				const amount = parseFloat(columns[1]);
				total += amount;
			}
		});
		console.log(total);
	} catch (err) {
		console.error(err);
	}
}

const filePath = path.join(__dirname, 'Banking.csv');

BankTransactionAnalyzerSimple(filePath);

function BankTransactionAnalyzerExtend(filePath) {
	try {
		const data = fs.readFileSync(filePath, 'utf8');
		const lines = data.split('\n');
		let total = 0;

		lines.forEach(line => {
			const columns = line.split(',');

			if (columns[0] && columns[1]) {
				const dateParts = columns[0].split('-');
				const date = new Date(dateParts[2], dateParts[1] - 1, dateParts[0]);

				if (date.getMonth() === 0) {
					const amount = parseFloat(columns[1]);
					total += amount;
				}
			}
		});
		console.log(total);
	} catch (err) {
		console.error(err);
	}
}

BankTransactionAnalyzerExtend(filePath);