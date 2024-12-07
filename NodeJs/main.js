const crypto = require('crypto');

//console.log("Benchmark tool de consola para comparar el cifrado en MD5");
//console.log("Primer argumento es el numero de iteraciones");

if (process.argv.length < 3) {
    throw new Error("Primer argumento no es OPCIONAL");
}

// el primer argumento es el numero de iteraciones
const iterations = parseInt(process.argv[2], 10);

const start = process.hrtime.bigint();

for (let i = 0; i < iterations; i++) {
    const input = 'a'.repeat(i);
    const hash = getMd5Hash(input);
    //console.log(hash);
}

const end = process.hrtime.bigint();
const elapsedMilliseconds = Number(end - start) / 1000000;
//console.log(`Tiempo total para ${iterations} iteraciones: ${elapsedMilliseconds} ms`);
console.log(elapsedMilliseconds);

function getMd5Hash(input) {
    return crypto.createHash('md5').update(input).digest('hex').toUpperCase();
}