from flask import Flask, render_template

app = Flask(__name__)

@app.route('/')
def index():
    return render_template('tour.html')

@app.route('/tour')
def tour():
    return render_template('index.html')

@app.route('/bron')
def bron():
    return render_template('bron.html')

@app.route('/cash')
def cash():
    return render_template('cash.html')


if __name__ == "__main__":
    app.run(debug = True)