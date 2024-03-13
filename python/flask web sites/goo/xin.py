from flask import Flask, render_template

app = Flask(__name__)

@app.route('/')
def index():
    return render_template('index.html')

@app.route('/smart')
def smart():
    return render_template('smart.html')

@app.route('/obrat')
def obrat():
    return render_template('obrat.html')

@app.route('/nout')
def nout():
    return render_template('nout.html')


@app.route('/kurs')
def kurs():
    return render_template('htmlfile.html')


if __name__ == "__main__":
    app.run(debug = True)