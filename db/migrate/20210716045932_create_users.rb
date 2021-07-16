class CreateUsers < ActiveRecord::Migration[6.0]
  def change
    create_table :users do |t|
      t.String! :id
      t.String! :login

      t.timestamps
    end
  end
end
