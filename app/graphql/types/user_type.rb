module Types
  class UserType < Types::BaseObject
    field :id, String, null: false
    field :login, String, null: false
  end
end
