//
//  ViewController.swift
//  PlaygroundProject
//
//  Created by Christopher Wood on 4/22/19.
//  Copyright © 2019 Christopher Wood. All rights reserved.
//

import UIKit

class ViewController: UIViewController {
    @IBOutlet weak var UsernameLabel: UILabel!
    @IBOutlet weak var LabelToUpdate: UILabel!
    @IBOutlet weak var UsernameTextInput: UITextField!
    
    override func viewDidLoad() {
        super.viewDidLoad()
        UsernameLabel.text = "Enter your Username:"
    }

    
    @IBAction func UsernameFieldChanged(_ sender: Any) {
        LabelToUpdate.text = UsernameTextInput.text
    }
    
}

