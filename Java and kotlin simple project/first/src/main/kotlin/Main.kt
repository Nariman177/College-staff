fun main() {
    val tom = Person("Tom")
    val bob = Person("Bob", 41)
    val sam = Person("Sam", 32, "JetBtains")

    println("Name: ${tom.name}  Age: ${tom.age}  Company: ${tom.company}")
    println("Name: ${bob.name}  Age: ${bob.age}  Company: ${bob.company}")
    println("Name: ${sam.name}  Age: ${sam.age}  Company: ${sam.company}")
}
class Person(_name: String){
    val name = _name
    var age: Int = 0
    var company: String = "Undefined"

    constructor(_name: String, _age: Int) : this(_name){
        age = _age
    }

    constructor(_name: String, _age: Int, _comp: String) : this(_name, _age){
        company = _comp
    }
}